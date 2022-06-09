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
    //Jerome Asselin ==> 2195077

    /// <summary>
    /// Implementation d'heritage avec la classe INotifyPropertyChanged pour faire la selection de l'item du picker et utiliser les proprietes de l'objet pour le binding
    /// </summary>
    internal class CarsViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Methode qui verifie si il y a un changement a la proprietee de l'objet. si oui la modifie
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public ObservableCollection<Car> Cars { get; set; }


        /// <summary>
        /// Filtre la liste pour populer le controle Picker
        /// </summary>
        public CarsViewModel()
        {
            this.Cars = new ObservableCollection<Car>(CarsDbContext.List.Where(car => car.Etat == "Louer"));

        }

            Car selectedCar;

        /// <summary>
        /// Methode d'acces qui utilise la methode OnPropertyChanged pour acceder au propriete de l'objet selectionner
        /// </summary>
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
