namespace MAUITest;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
        InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		labelslider.Text= slider.Value.ToString();  

    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        labelslider.Text = stepper.Value.ToString();
    }
}