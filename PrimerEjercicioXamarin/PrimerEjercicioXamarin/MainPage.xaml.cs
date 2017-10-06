using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimerEjercicioXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            inicializar();
        }

        private void inicializar()
        {
            btnPrimero.Clicked += BtnPrimero_Clicked;
        }

        private void BtnPrimero_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }
    }
}
