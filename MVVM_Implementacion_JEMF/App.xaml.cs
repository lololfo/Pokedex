using MVVM_Implementacion_JEMF.Vistas;
using MVVM_Implementacion_JEMF.VistaModelo;
using MVVM_Implementacion_JEMF;
using MVVM_Implementacion_JEMF.Vistas.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Implementacion_JEMF
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
