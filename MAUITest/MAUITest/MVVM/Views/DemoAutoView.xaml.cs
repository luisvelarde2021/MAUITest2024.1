using MAUITest.MVVM.ViewModels;

namespace MAUITest.MVVM.Views;

public partial class DemoAutoView : ContentPage
{
	public DemoAutoView()
	{
		InitializeComponent();
		BindingContext = new DemoAutoProperty();
	}
}