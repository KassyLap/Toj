namespace Toj;

public partial class Importante : ContentPage
{
	public Importante()
	{
		InitializeComponent();
	}
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Nombre());
    }
}
