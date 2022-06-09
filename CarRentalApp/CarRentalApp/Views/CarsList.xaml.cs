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
    public partial class CarsList : ContentPage
    {
        public ObservableCollection<Car> Cars { get; set; }
        public CarsList()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.Cars = new ObservableCollection<Car>(CarsDbContext.List);
            OnPropertyChanged(nameof(Cars));
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Car selectedCar = (Car)e.CurrentSelection[0];
            CarDetails details = new CarDetails();
            details.BindingContext = selectedCar;
            await this.Navigation.PushAsync(details);
        }
    }
}