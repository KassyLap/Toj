namespace Toj;

public partial class Nombre : ContentPage
{
    public Nombre()
    {
        InitializeComponent();
    }

    void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Edad());

    }
}