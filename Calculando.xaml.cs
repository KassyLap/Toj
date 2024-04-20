namespace Toj
{
    public partial class Calculando : ContentPage
    {
        public double tmb;
        public Calculando(double bmi, double tmb)
        {
            InitializeComponent();


            Task.Delay(TimeSpan.FromSeconds(3)).ContinueWith(t =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PushAsync(new BMI(bmi, tmb));
                });
            });
        }
    }
}