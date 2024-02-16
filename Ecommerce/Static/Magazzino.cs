using System.Collections.Generic;

namespace Ecommerce
{
    public static class Magazzino
    {
        public static List<Articolo> Articoli = new List<Articolo>()
    {
               new Articolo
            {
                Id = 1,
                Nome = "Zaino da Viaggio",
                Descrizione = "Zaino spazioso e resistente, ideale per le tue avventure all'aria aperta o i viaggi in città. Dotato di scomparti multipli per una facile organizzazione.",
                Prezzo = 10,
                ImmaginePath = "/Content/assets/images/backpack.png"
            },
            new Articolo
            {
                Id = 2,
                Nome = "Borsa Elegante",
                Descrizione = "Borsa chic e versatile, perfetta per un'uscita serale o come accessorio da giorno. Realizzata in materiali di alta qualità con finiture di lusso.",
                Prezzo = 20,
                ImmaginePath = "/Content/assets/images/bag.png"
            },
            new Articolo
            {
                Id = 3,
                Nome = "Cappellino Sportivo",
                Descrizione = "Cappellino in cotone con visiera, ideale per le giornate soleggiate o per un tocco casual al tuo outfit. Comodo e regolabile per ogni taglia.",
                Prezzo = 30,
                ImmaginePath = "/Content/assets/images/cap.png"
            },
            new Articolo
            {
                Id = 4,
                Nome = "Pantaloni Cargo",
                Descrizione = "Pantaloni cargo robusti, con tasche laterali per un look funzionale e alla moda. Perfetti per escursioni o per un stile casual quotidiano.",
                Prezzo = 40,
                ImmaginePath = "/Content/assets/images/cargo_pants.png"
            },
            new Articolo
            {
                Id = 5,
                Nome = "Giacca Antivento",
                Descrizione = "Giacca leggera ma protettiva, ideale per le stagioni di passaggio. Protegge dal vento e dalla pioggia leggera, mantenendo uno stile impeccabile.",
                Prezzo = 50,
                ImmaginePath = "/Content/assets/images/jacket.png"
            },
            new Articolo
            {
                Id = 6,
                Nome = "Scarpe da Ginnastica",
                Descrizione = "Scarpe da ginnastica confortevoli e stilose, progettate per supportare il tuo piede durante attività sportive e per il tempo libero.",
                Prezzo = 60,
                ImmaginePath = "/Content/assets/images/shoes.png"
            },
            new Articolo
            {
                Id = 7,
                Nome = "Occhiali da Sole",
                Descrizione = "Occhiali da sole con lenti polarizzate per una visione ottimale e una protezione UV completa. Un must-have per ogni stagione.",
                Prezzo = 70,
                ImmaginePath = "/Content/assets/images/Sunglasses.png"
            },
            new Articolo
            {
                Id = 8,
                Nome = "T-shirt in Cotone",
                Descrizione = "T-shirt basic ma essenziale, realizzata in cotone morbido e traspirante. Un capo versatile che non può mancare nel tuo guardaroba.",
                Prezzo = 80,
                ImmaginePath = "/Content/assets/images/tshirt.png"
            },

           new Articolo
            {
                Id = 9,
                Nome = "Portafoglio in Pelle",
                Descrizione = "Portafoglio elegante e funzionale, con scomparti per carte di credito e banconote. Realizzato in vera pelle, è un classico che dura nel tempo.",
                Prezzo = 90,
                ImmaginePath = "/Content/assets/images/wallet.png"
            },
            new Articolo
            {
                Id = 10,
                Nome = "Felpa con Cerniera",
                Descrizione = "Una felpa comoda con cerniera, perfetta per aggiungere un strato caldo nei giorni più freschi. Unisce comfort e stile.",
                Prezzo = 100,
                ImmaginePath = "/Content/assets/images/zip_hoodie.png"
            },
    };
    }
}

