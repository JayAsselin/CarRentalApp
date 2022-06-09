using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalApp.Models
{
    //Jerome Asselin ==> 2195077
    public class Car
    {
        public string Modele { get; set; }
        public string Immatriculation { get; set; }
        public int Kilometrage { get; set; }
        public string Etat { get; set; }
        public string Categorie { get; set; }
        public int PrixLocation { get; set; }
        public int DureeLocation { get; set; }
        public string ImageUrl { get; set; }
        public string DisplayText => $"{Modele} - {Immatriculation}";
    }
}
