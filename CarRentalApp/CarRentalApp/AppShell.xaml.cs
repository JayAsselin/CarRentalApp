using CarRentalApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarRentalApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        //Jerome Asselin ==> 2195077
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}