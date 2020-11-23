using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarroselPages.TipoPagina.Navegation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();

        }
        private void MudarPaginaDois(object sender, EventArgs args) {
            Navigation.PushAsync(new Page2() { BarBackgroundColor = Color.Red });
        }
    }
}