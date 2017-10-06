using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimerEjercicioXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();

            Inicializar();
        }

        private void Inicializar()
        {
            imgCambiante.Source = ImageSource.FromResource("PrimerEjercicioXamarin.img.moto.jpg");
            btnTerceraPantalla.Clicked += BtnTerceraPantalla_Clicked;
        }

        private void BtnTerceraPantalla_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThirdPage());
        }

        private void swMotero_Toggled(object sender, ToggledEventArgs e)
        {
            if (swMotero.IsToggled == true)
            {
                lblMotero.Text = "Eres un macarra";
                imgCambiante.Source = ImageSource.FromResource("PrimerEjercicioXamarin.img.coche.jpg");
            }
            else {
                lblMotero.Text = "Eres un motero";
                imgCambiante.Source = ImageSource.FromResource("PrimerEjercicioXamarin.img.moto.jpg");
            }
        }
    }
}