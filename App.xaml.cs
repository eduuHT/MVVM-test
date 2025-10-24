using MVVM_test.MVVM.Views;

namespace MVVM_test
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CommandsView();
        }
    }
}
