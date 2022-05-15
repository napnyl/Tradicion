using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tradicion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Task.Run(RotateImage);
        }

        private async void RotateImage()
        {
            while (true)
            {
                await BannerImg.RelRotateTo(360, 25000, Easing.Linear);
            }
        }
    }
}
