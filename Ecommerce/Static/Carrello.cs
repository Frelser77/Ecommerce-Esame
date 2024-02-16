using System.Collections.Generic;

namespace Ecommerce
{
    // classe statica per gestire il carrello 
    public static class CarrelloClass
    {
        // lista di articoli nel carrello
        public static List<Articolo> ArticoliNelCarrello = new List<Articolo>();

        // metodo per aggiungere un articolo al carrello richiamando il metodo Add della lista
        public static void AggiungiArticolo(Articolo articolo)
        {
            ArticoliNelCarrello.Add(articolo);
        }

        // metodo per rimuovere un articolo dal carrello richiamando il metodo Remove della lista
        public static void RimuoviArticolo(int articoloId)
        {
            ArticoliNelCarrello.RemoveAll(a => a.Id == articoloId);
        }

        // metodo per svuotare il carrello richiamando il metodo Clear della lista
        public static void SvuotaCarrello()
        {
            ArticoliNelCarrello.Clear();
        }
    }
}