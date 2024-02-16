using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Ecommerce
{
    public partial class Dettaglio : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    Articolo articolo = Magazzino.Articoli.FirstOrDefault(a => a.Id == id);
                    if (articolo != null)
                    {
                        imgProdotto.ImageUrl = articolo.ImmaginePath;
                        lblNome.Text = articolo.Nome;
                        lblDescrizione.Text = articolo.Descrizione;
                        lblPrezzo.Text = articolo.Prezzo.ToString("C2");
                    }
                }
            }
        }

        // metodo per aggiungere un articolo al carrello tramite cookie 
        protected void BtnAggiungiCarrello_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int idArticolo = int.Parse(Request.QueryString["id"]);
                HttpCookie carrelloCookie = Request.Cookies["Carrello"] ?? new HttpCookie("Carrello");
                Dictionary<int, int> articoliCarrello = EstraiArticoliDaCookie(carrelloCookie);

                if (articoliCarrello.ContainsKey(idArticolo))
                {
                    articoliCarrello[idArticolo]++; // Incrementa la quantità
                }
                else
                {
                    articoliCarrello[idArticolo] = 1; // Aggiunge un nuovo articolo con quantità 1
                }

                // Salva il nuovo valore nel cookie
                carrelloCookie.Value = string.Join(",", articoliCarrello.Select(kvp => $"{kvp.Key}={kvp.Value}"));
                carrelloCookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(carrelloCookie);

            }
        }

        // metodo per estrarre gli articoli dal cookie del carrello e restituirli come un dizionario di id e quantità di articoli 
        // (se il cookie non esiste o è vuoto, restituisce un dizionario vuoto)
        // (se il cookie contiene valori non validi, li ignora)
        // (se il cookie contiene valori duplicati, usa l'ultimo valore)
        private Dictionary<int, int> EstraiArticoliDaCookie(HttpCookie carrelloCookie)
        {
            Dictionary<int, int> articoliCarrello = new Dictionary<int, int>();
            if (carrelloCookie != null && !string.IsNullOrEmpty(carrelloCookie.Value))
            {
                articoliCarrello = carrelloCookie.Value.Split(',')
                    .Select(s => s.Split('='))
                    .Where(arr => arr.Length == 2 && int.TryParse(arr[0], out _) && int.TryParse(arr[1], out _))
                    .ToDictionary(arr => int.Parse(arr[0]), arr => int.Parse(arr[1]));
            }
            return articoliCarrello;
        }

    }
}