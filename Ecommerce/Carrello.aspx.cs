using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Carrello : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CaricaArticoliCarrello();

                // visibilitá del bottono svuota carrello
                HttpCookie carrelloCookie = Request.Cookies["Carrello"];
                if (carrelloCookie != null)
                {
                    btnSvuotaCarrello.Visible = true;
                }
                else
                {
                    btnSvuotaCarrello.Visible = false;
                }
            }
        }

        // metodo per caricare gli articoli nel carrello e calcolare il prezzo totale del carrello
        private void CaricaArticoliCarrello()
        {
            HttpCookie carrelloCookie = Request.Cookies["Carrello"];
            if (carrelloCookie != null)
            {
                Dictionary<int, int> articoliCarrello = EstraiArticoliDaCookie(carrelloCookie);
                var articoliConQuantita = Magazzino.Articoli
                    .Where(a => articoliCarrello.ContainsKey(a.Id))
                    .Select(a => new
                    {
                        Articolo = a,
                        Quantita = articoliCarrello[a.Id],
                        PrezzoTotale = a.Prezzo * articoliCarrello[a.Id]
                    }).ToList();

                // Aggiorna  repeater 
                rptCarrello.DataSource = articoliConQuantita;
                rptCarrello.DataBind();

                // Calcola il prezzo totale del carrello
                decimal prezzoTotaleCarrello = articoliConQuantita.Sum(a => a.PrezzoTotale);


                Literal ltTotaleCarrello = (Literal)rptCarrello.Controls[rptCarrello.Controls.Count - 1].FindControl("ltTotaleCarrello");
                if (ltTotaleCarrello != null)
                {
                    ltTotaleCarrello.Text = prezzoTotaleCarrello.ToString("C2");
                }
            }
            else
            {
                ltMessaggioCarrelloVuoto.Text = "<h4>Non ci sono articoli nel carrello.</h4>";
            }
        }



        // metodo per estrarre gli articoli dal cookie del carrello e restituirli come un dizionario di id e quantità di articoli
        private void AggiornaCookieCarrello(Dictionary<int, int> articoliCarrello)
        {
            HttpCookie carrelloCookie = new HttpCookie("Carrello");
            if (articoliCarrello.Count > 0)
            {
                // Se ci sono articoli nel carrello, aggiorna il valore del cookie.
                carrelloCookie.Value = string.Join(",", articoliCarrello.Select(kvp => $"{kvp.Key}={kvp.Value}"));
                carrelloCookie.Expires = DateTime.Now.AddDays(1);
            }
            else
            {
                // Se non ci sono articoli, imposta la data di scadenza nel passato per rimuovere il cookie.
                carrelloCookie.Expires = DateTime.Now.AddDays(-1);
            }
            Response.Cookies.Add(carrelloCookie);
        }

        // metodo per rimuovere un articolo dal carrello e aggiornare il cookie del carrello 
        protected void LnkRimuovi_Command(object sender, CommandEventArgs e)
        {
            int idArticolo = Convert.ToInt32(e.CommandArgument);
            Dictionary<int, int> articoliCarrello = EstraiArticoliDaCookie(Request.Cookies["Carrello"]);

            if (articoliCarrello.ContainsKey(idArticolo))
            {
                if (articoliCarrello[idArticolo] > 1)
                {
                    articoliCarrello[idArticolo]--; // Decrementa la quantità.


                }
                else
                {
                    articoliCarrello.Remove(idArticolo); // Rimuove completamente l'articolo.
                }
                AggiornaCookieCarrello(articoliCarrello);// Aggiorna il cookie
                Response.Redirect(Request.RawUrl);

                // Se dopo aver rimosso l'articolo, il carrello è vuoto, forzo il refresh della pagina.
                if (articoliCarrello.Count == 0)
                {
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    CaricaArticoliCarrello(); // Ricarico gli articoli del carrello dopo l'aggiornamento.
                }
            }
        }


        protected void BtnSvuotaCarrello_Click(object sender, EventArgs e)
        {
            HttpCookie carrelloCookie = new HttpCookie("Carrello")
            {
                Value = null,
                Expires = DateTime.Now.AddDays(-1)
            };
            Response.Cookies.Add(carrelloCookie);
            Response.Redirect(Request.RawUrl); // Ricarico la pagina per aggiornare il contenuto visualizzato.
        }


        // metodo per estrarre gli articoli dal cookie del carrello e restituirli come un dizionario di id e quantità di articoli 
        private Dictionary<int, int> EstraiArticoliDaCookie(HttpCookie carrelloCookie)
        {
            Dictionary<int, int> articoliCarrello = new Dictionary<int, int>();

            if (carrelloCookie != null && !string.IsNullOrEmpty(carrelloCookie.Value))
            {
                string[] articoli = carrelloCookie.Value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string articolo in articoli)
                {
                    string[] coppia = articolo.Split('=');
                    if (coppia.Length == 2)
                    {
                        int id, quantita;

                        if (int.TryParse(coppia[0], out id) && int.TryParse(coppia[1], out quantita))
                        {
                            articoliCarrello[id] = quantita;
                        }
                    }
                }
            }

            return articoliCarrello;
        }

    }
}


