using Android.App;

namespace Toj;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Importante());

    }
    //Instagram 
    private async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Launcher.OpenAsync(new Uri("https://www.instagram.com/eduardo.tucan?igsh=MXRmYzBvOWZ3NXV6eQ=="));
    }
    //Facebook
    private async void ImageButton_Clicked_1(System.Object sender, System.EventArgs e)
    {
        await Launcher.OpenAsync(new Uri("https://www.facebook.com/profile.php?id=61558241746908"));
    }
}

