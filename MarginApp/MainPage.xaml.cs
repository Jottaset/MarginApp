using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MarginApp
{
    public partial class MainPage : ContentPage
    {
        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            //label_rodante.Rotation = slider_stop.Value;

            int labelValor = Convert.ToInt32(slider_stop.Value);

            label_valueSlider.Text = labelValor.ToString();

            if(labelValor == 0 || labelValor == 360)
            {
                label_rodante.Text = "ESTAVEL";
            }
            else
            {
                label_rodante.Text = "GIRANDO";
            }

        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
