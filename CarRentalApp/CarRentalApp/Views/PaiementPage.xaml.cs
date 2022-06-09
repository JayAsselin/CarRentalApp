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
    public partial class PaiementPage : ContentPage
    {
        public ObservableCollection<Car> Cars { get; set; }
        public PaiementPage()
        {
            InitializeComponent();
        }
        public PaiementPage(Car car)
        {
            InitializeComponent();
            this.BindingContext = car;
            this.Cars = new ObservableCollection<Car>(CarsDbContext.List);
            invoice.Text = $"Total de la facture : {car.DureeLocation *= car.PrixLocation}$";
        }


        private async void dismiss_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Confirmation", "Paiement recu!\nMerci d'avoir fait affaire avec nous", "Ok");
            await Navigation.PopModalAsync();
        }
    }
}