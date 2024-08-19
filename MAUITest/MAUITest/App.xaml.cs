
using MAUITest.MVVM.Views;
namespace MAUITest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new DemoAutoView());
        }
    }
}
