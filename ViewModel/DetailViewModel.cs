using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tradicion.ViewModel
{
    public class DetailViewModel:BaseViewModel
    {
        public DetailViewModel()
        {
            DetailList = GetDetail();
        }

        public List<Pick> DetailList { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        private List<Pick> GetDetail()
        {
            return new List<Pick>
            {
                new Pick {Title="Chugchucara", Image="IMG01", Description="Delicioso plato que contiene mote y trozos de carne de cerdo.", Price="$8.50"},
                new Pick {Title="Caldo de pata", Image="IMG02", Description="Exquisita sopa tradicional que se prepara con patas de res.", Price="$7.90"},
                new Pick {Title="Yahuarlocro", Image="IMG03", Description="Tradicional sopa a base de papas y tripas de borrego.", Price="$9.00"},
                new Pick {Title="Parrillada", Image="IMG04", Description="Mezcla de carnes perfectamente asadas al carbón", Price="$15.25"},
                new Pick {Title="Papas con cuero", Image="IMG05", Description="Sopa que contiene cuero de cerdo y papas.", Price="$6.75"}
            };
        }
    }
}
