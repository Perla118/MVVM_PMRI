using MVVM_PMRI.Modelo;
using MVVM_PMRI.Vista;
using MVVM_PMRI.Vista.Pokemon;
using MVVM_PMRI.VistaModelo;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_PMRI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Listapokemon());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
