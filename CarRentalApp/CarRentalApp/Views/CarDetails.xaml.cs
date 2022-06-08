using CarRentalApp.Data;
using CarRentalApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarRentalApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarDetails : ContentPage
    {
        public CarDetails()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var btn = sender as Button;
                var available = btn.BindingContext as Car;
                if (available.Etat == "Louer")
                    DisplayAlert("Info", "Désolez cette voiture est déjà loué", "Fermer");
                else
                {
                   DisplayAlert("Info", "Merci d'avoir loué chez nous! Vous pouvez venir chercher la voiture.", "Fermer");
                    available.Etat = "Louer";
                }
                    
            }
            catch (Exception ex)
            {
                DisplayAlert("Info", ex.Message, "Fermer");
            }
        }
    }
}

/*
1. Click sur dans CarDetails
2. Recuper le vehicule de la list
3. Changer l'etat
4. CarViewModel recuper la list
5. Affiche la list dans rental return
 */