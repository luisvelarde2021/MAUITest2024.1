using MAUITest.MVVM.ViewModels;

namespace MAUITest.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
		BindingContext = new PeopleViewModel();
	}
}