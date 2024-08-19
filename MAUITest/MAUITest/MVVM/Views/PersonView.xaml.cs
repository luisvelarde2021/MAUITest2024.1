using MAUITest.MVVM.ViewModels;

namespace MAUITest.MVVM.Views;

public partial class PersonView : ContentPage
{
    public PersonView()
    {
        InitializeComponent();
        BindingContext = new PersonViewModel();

    }
}