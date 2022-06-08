using CarRentalApp.Data;
using CarRentalApp.Models;
using CarRentalApp.ViewModels;
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
    public partial class RentalReturn : ContentPage
    {
        public RentalReturn()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                this.BindingContext = new CarsViewModel();
            }
            catch (Exception ex)
            {
                DisplayAlert("Info", ex.Message, "Close");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var btn = sender as Button;
                var available = btn.BindingContext as Car;
                if (available.Etat == "Louer")
                {
                    DisplayAlert("Info", "Merci d'avoir rapporter la voiture", "Fermer");
                    available.Etat = "Disponible";
                    //
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Info", ex.Message, "Fermer");
            }
        }
    }
}