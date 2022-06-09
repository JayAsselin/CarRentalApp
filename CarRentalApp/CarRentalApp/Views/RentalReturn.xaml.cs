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
    //Jerome Asselin ==> 2195077
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                //var btn = sender as Button;
                BindingContext = pickerList.SelectedItem as Car;
                var available = BindingContext as Car;
                if (available.Etat != null)
                {
                    available.Etat = "Disponible";
                    await Navigation.PushModalAsync(new PaiementPage(available));

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Info", ex.Message, "Fermer");
            }
        }
    }
}