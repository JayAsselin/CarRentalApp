using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalApp.Models
{
    public class Car
    {
        public string Modele { get; set; }
        public string Immatriculation { get; set; }
        public int Kilometrage { get; set; }
        public string Etat { get; set; }
        public string Categorie { get; set; }
        public int PrixLocation { get; set; }
        public string ImageUrl { get; set; }
        public string DisplayText => $"{Modele} - {Immatriculation}";
    }
}
