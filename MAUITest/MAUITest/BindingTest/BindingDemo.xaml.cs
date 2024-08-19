namespace MAUITest.BindingTest;

public partial class BindingDemo : ContentPage
{
	public BindingDemo()
	{
		InitializeComponent();
	}

    private void btnOk_Clicked(object sender, EventArgs e)
    {
		var person = new Person
		{
			Name = "Luis Velarde",
			Phone = "664 775 4404",
			Address = "oporto 47"
		};
		BindingContext = person;	
		//lblName.SetBinding(Label.TextProperty,"Name");	

		//var personBinding = new Binding();
		//personBinding.Source = person;
		//personBinding.Path = "Name";

		//lblName.SetBinding(Label.TextProperty, personBinding);


	}
}