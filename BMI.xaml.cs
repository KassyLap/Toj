namespace Toj
{
    public partial class BMI : ContentPage
    {
        public double bmi;
        public double tmb;
        public BMI(double bmi, double tmb)
        {
            InitializeComponent();

            result.Text = $"{bmi:F2}";

            string resultado = "";
            if (bmi < 18.5)
            {
                resultado = "Bajo";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                resultado = "Normal";
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                resultado = "Sobrepeso";
            }
            else if (bmi >= 30.0 && bmi <= 34.9)
            {
                resultado = "Obesidad I";
            }
            else if (bmi >= 35.0 && bmi <= 39.9)
            {
                resultado = "Obesidad II";
            }
            else
            {
                resultado = "Obesidad III";
            }

            peso.Text = resultado;

            this.tmb = tmb;

        }

        void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Calorias(tmb));

        }
    }
}