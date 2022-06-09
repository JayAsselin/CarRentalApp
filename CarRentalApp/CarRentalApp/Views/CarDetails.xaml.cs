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
    //Jerome Asselin ==> 2195077
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarDetails : ContentPage
    {
        public CarDetails()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var btn = sender as Button;
                var available = btn.BindingContext as Car;
                if (available.Etat == "Louer")
                    await DisplayAlert("Info", "Désolez cette voiture est déjà loué", "Fermer");
                else
                {
                    var reponse = await DisplayPromptAsync("Question", "Combien de jour voulez vous louer cette voiture?", "Ok", "Annuler", keyboard:Keyboard.Numeric);
                    if (reponse != null)
                    {
                        await DisplayAlert("Info", "Merci d'avoir loué chez nous!", "Fermer");
                        available.Etat = "Louer";
                        available.DureeLocation = Convert.ToInt32(reponse);
                        cancel.IsVisible = true;
                    }
                   
                }
                    
            }
            catch (Exception ex)
            {
                await DisplayAlert("Info", ex.Message, "Fermer");
            }
        }

        private async void cancel_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var available = btn.BindingContext as Car;
            var alert = await DisplayAlert("Attention", "Voulez vous vraiment annuler la location?", "Oui", "Non");
            if (alert)
            {
                await DisplayAlert("Attention", "Location annuler avec succes", "Fermer");
                available.Etat = "Disponible";
                cancel.IsVisible = false;
            }
        }
    }
}