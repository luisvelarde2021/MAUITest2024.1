using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUITest.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public CommandsViewModel()
        {
                
        }

        public String SearchItem { get; set; }

        public ICommand ClickCommand => new Command(() => App.Current.MainPage.DisplayAlert("Title","Message","Ok"));

        public ICommand SearchCommand => new Command(() => App.Current.MainPage.DisplayAlert("Búsqueda",$"Buscaste: {SearchItem}", "Ok"));
    }
}

