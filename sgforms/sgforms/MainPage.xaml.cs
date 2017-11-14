using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sgforms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Img1.Source = ImageSource.FromFile("day.jpg");
            Img2.Source = ImageSource.FromFile("night.jpg");

            
        }

        private void Sl_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var slider = sender as Slider;
            Label1.Text = slider.Value.ToString();
            Img1.Opacity = Sl.Value;
            Img2.Opacity = 1 - Sl.Value;
        }
    }
}
