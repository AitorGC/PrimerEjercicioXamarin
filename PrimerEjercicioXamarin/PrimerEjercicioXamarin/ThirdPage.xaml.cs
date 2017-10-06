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
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            pickerEncuesta.SelectedIndex = 1;
            pickerEncuesta.SelectedIndexChanged += PickerEncuesta_SelectedIndexChanged;
        }

        private void PickerEncuesta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerEncuesta.SelectedIndex == 1)
            {
                //HACER ALGO
            }
            else {
                //HACER ALGO MÁS
            }
        }
    }
}