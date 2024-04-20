namespace Toj
{ 
public partial class Calorias : ContentPage
{
    public double tmb;
    public Calorias(double tmb)
    {
        InitializeComponent();
            this.tmb = tmb;
        Result.Text = $"{tmb} calorias";
    }

}

}