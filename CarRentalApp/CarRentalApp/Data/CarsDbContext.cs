using CarRentalApp.Models;
using CarRentalApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarRentalApp.Data
{
    //Jerome Asselin ==> 2195077
    internal class CarsDbContext
    {
        public static IList<Car> List = new ObservableCollection<Car>
        {
            new Car
            {
                Modele = "Dodge Caravan",
                Immatriculation = "77B C8F",
                Kilometrage = 115000,
                Etat = "Disponible",
                Categorie = "Grande",
                PrixLocation = 90,
                DureeLocation = 0,
                ImageUrl = "https://picolio.auto123.com/auto123-media/Dodge-Grand-Caravan-SXT-2020%20(9).jpg"
            },
            new Car
            {
                Modele = "Dodge Charger",
                Immatriculation = "234 B9T",
                Kilometrage = 35000,
                Etat = "Disponible",
                Categorie = "Petite",
                PrixLocation = 175,
                DureeLocation = 0,
                ImageUrl = "https://medias.fcacanada.ca/jellies/renditions/2022/800x510/CC22_LDDM48_2DG_PX8_APA_XXX_XXX_XXX.775f7b28a1ea274f57eadc25a37137dd.png"
            },
            new Car
            {
                Modele = "Ford Escape",
                Immatriculation = "9A2 23I",
                Kilometrage = 165050,
                Etat = "Disponible",
                Categorie = "VUS",
                PrixLocation = 115,
                DureeLocation = 0,
                ImageUrl = "https://platform.cstatic-images.com/large/in/v2/stock_photos/5ab77237-6021-472c-8f4f-8c1c41807c24/6f0af1da-fe10-4798-85bd-b5a73575102d.png"
            },
            new Car
            {
                Modele = "Ford Ranger",
                Immatriculation = "8H4 R2Y",
                Kilometrage = 55000,
                Etat = "Disponible",
                Categorie = "Moyenne",
                PrixLocation = 135,
                DureeLocation = 0,
                ImageUrl = "https://cars.usnews.com/static/images/Auto/izmo/i159614968/2022_ford_ranger_angularfront.jpg"
            },
            new Car
            {
                Modele = "Mercedes Sprinter",
                Immatriculation = "J89 J2L",
                Kilometrage = 265000,
                Etat = "Disponible",
                Categorie = "Grande",
                PrixLocation = 140,
                DureeLocation = 0,
                ImageUrl = "https://assets.mbvans.com/e_trim/Mercedes-Benz-Vans/Canada/BYO/2021/Sprinter/cargo-van/MY19_2C1444_SI_SR_9147_DS"
            },
            new Car
            {
                Modele = "Mercedes C300",
                Immatriculation = "98B 23R",
                Kilometrage = 68000,
                Etat = "Disponible",
                Categorie = "Petite",
                PrixLocation = 215,
                DureeLocation = 0,
                ImageUrl = "https://www.ccarprice.com/products/Mercedes_Benz_C300_Sedan_2021.jpg"
            },
            new Car
            {
                Modele = "BMW 2-Series",
                Immatriculation = "I9T U77",
                Kilometrage = 105000,
                Etat = "Disponible",
                Categorie = "Petite",
                PrixLocation = 250,
                DureeLocation = 0,
                ImageUrl = "https://cars.usnews.com/static/images/Auto/izmo/i159614891/2022_bmw_2_series_angularfront.jpg"
            },
            new Car
            {
                Modele = "BMW X3",
                Immatriculation = "3O2 TT5",
                Kilometrage = 35600,
                Etat = "Disponible",
                Categorie = "VUS",
                PrixLocation = 185,
                DureeLocation = 0,
                ImageUrl = "https://images.dealer.com/autodata/us/color/2021/USD10BMS201B0/416.jpg"
            },
            new Car
            {
                Modele = "Toyota Sienna",
                Immatriculation = "93I U4O",
                Kilometrage = 215000,
                Etat = "Disponible",
                Categorie = "Grande",
                PrixLocation = 125,
                DureeLocation = 0,
                ImageUrl = "https://crdms.images.consumerreports.org/c_lfill,w_470,q_auto,f_auto/prod/cars/cr/car-versions/19224-2021-toyota-sienna-xle"
            },
            new Car
            {
                Modele = "Subaru Crosstrek",
                Immatriculation = "8UR 34C",
                Kilometrage = 145000,
                Etat = "Disponible",
                Categorie = "Moyenne",
                PrixLocation = 160,
                DureeLocation = 0,
                ImageUrl = "https://www.subaru.ca/content/7907/media/General/thumbnail/Large/1374_6151.jpg"
            }
        };

        public static void AddToList(Car car)
        {
            List.Add(car);
        }
    }
}
