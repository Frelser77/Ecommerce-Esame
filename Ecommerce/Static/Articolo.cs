﻿namespace Ecommerce
{
    public class Articolo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string ImmaginePath { get; set; }
    }
}