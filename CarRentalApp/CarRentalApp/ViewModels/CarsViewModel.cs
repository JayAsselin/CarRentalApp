using CarRentalApp.Data;
using CarRentalApp.Models;
using CarRentalApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CarRentalApp.ViewModels
{
    internal class CarsViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public ObservableCollection<Car> CarReturn { get; set; }



        public CarsViewModel()
        {
            this.CarReturn = (ObservableCollection<Car>)CarsDbContext.List.Where(car => car.Etat == "Louer");

        }

            Car selectedCar;
        public Car SelectedCar
        {
            get { return selectedCar; }
            set
            {
                if (selectedCar != value)
                {
                        selectedCar = value;
                        OnPropertyChanged();
                }
            }
        }
        
    }
}
