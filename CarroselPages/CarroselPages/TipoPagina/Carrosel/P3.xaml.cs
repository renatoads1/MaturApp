﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarroselPages.TipoPagina.Carrosel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class P3 : ContentPage
    {
        public P3()
        {
            InitializeComponent();
        }
        private void MudarPagina(object sender, EventArgs args) {
            App.Current.MainPage = new NavigationPage(new Navegation.Pagina1());
        }
    }
}