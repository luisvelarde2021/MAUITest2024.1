using MAUITest.MVVM.ViewModels;

namespace MAUITest.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();

	}
}