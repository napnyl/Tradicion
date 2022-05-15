using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tradicion.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Picks = GetPicks();
        }

        public List<Pick> Picks { get; set; }

        public ICommand DetailCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new DetailPage()));

        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick {Title="Chugchucara", Image="IMG01", Description="Delicioso plato que contiene mote y chicharrón acompañado de trozos de carne de cerdo, cuero reventado y papas cocidas"},
                new Pick {Title="Caldo de pata", Image="IMG02", Description="Exquisita sopa tradicional que se prepara con patas de res, mote, cebolla, orégano y maní."},
                new Pick {Title="Yahuarlocro", Image="IMG03", Description="Tradicional sopa a base de papas y tripas de borrego, que se la acompaña tradicionalmente con aguacate y sangre del mismo animal."}
            };
        }
    }

    public class Pick
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }

    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
