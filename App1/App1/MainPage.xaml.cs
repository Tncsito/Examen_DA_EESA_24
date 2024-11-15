using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double Uno = Convert.ToInt32(uno.Text);
            double Dos = Convert.ToInt32(dos.Text);
            double r = Convert.ToInt32(R.Text);
            if (suma.IsChecked)
            {
                r = Uno + Dos;
                DisplayAlert("Resultado", $"{Uno} + {Dos} = {r}", "Cerrar");
            } 
            else if (resta.IsChecked)
            {
                r = Uno - Dos;
                DisplayAlert("Resultado", $"{Uno} - {Dos} = {r}", "Cerrar");
            }
            else if (division.IsChecked)
            {
                r = Uno / Dos;
                DisplayAlert("Resultado", $"{Uno} / {Dos} = {r}", "Cerrar");
            }
            else if (multiplicacion.IsChecked)
            {
                r = Uno * Dos;
                DisplayAlert("Resultado", $"{Uno} * {Dos} = {r}", "Cerrar");
            }
            else
            {
                DisplayAlert("Error", "Valores no definidos correctamente", "Cerrar");
            }
            R.Text = r.ToString();
        }
    }
}
