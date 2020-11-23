using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarroselPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TipoPagina.Carrosel.IntroducaoApp();
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
