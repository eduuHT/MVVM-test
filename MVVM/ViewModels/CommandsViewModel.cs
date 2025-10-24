using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_test.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand ClickCommand { get; }

        public ICommand SearchCommand { get; }

        public string SearchData { get; set; }


        public CommandsViewModel()
        {
            ClickCommand = new Command(() =>
            {
            App.Current.MainPage.DisplayAlert("Title", "Message", "Ok");
            });

            SearchCommand = new Command((search) =>
            {
                var data = search;
            });
        }
        private void Alert()
        {
        }
    }

}
