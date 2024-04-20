namespace Toj
{
    public partial class Objetivos : ContentPage
    {
        private double tmb;
        private double bmi;
        private string nivelEjercicioSeleccionado;
        private double weightInKg;
        private double heightInMeters;
        private string generoSeleccionado;
        private int ageValue;

        public Objetivos(double bmi, string nivelEjercicioSeleccionado, double weightInKg, double heightInMeters, string generoSeleccionado, int ageValue)
        {
            InitializeComponent();
            this.tmb = tmb;
            this.bmi = bmi;
            this.nivelEjercicioSeleccionado = nivelEjercicioSeleccionado;
            this.weightInKg = weightInKg;
            this.heightInMeters = heightInMeters;
            this.generoSeleccionado = generoSeleccionado;
            this.ageValue = ageValue;

            var heightInCm = (int)(heightInMeters * 100);

            if (generoSeleccionado == "Masculino")
            {
                tmb = (int)((10 * weightInKg) + (6.25 * heightInCm) - (5 * ageValue) + 5);
            }
            else if (generoSeleccionado == "Femenino")
            {
                tmb = (int)((10 * weightInKg) + (6.25 * heightInCm) - (5 * ageValue) - 161);
            }

            switch (nivelEjercicioSeleccionado)
            {
                case "Poco o ningún ejercicio":
                    tmb = (int)(tmb * 1.2);
                    break;
                case "Ejercicio Ligero (1-3 días)":
                    tmb = (int)(tmb * 1.375);
                    break;
                case "Ejercicio Moderado (3-5 días)":
                    tmb = (int)(tmb * 1.55);
                    break;
                case "Ejercicio Fuerte (6-7 días)":
                    tmb = (int)(tmb * 1.725);
                    break;
                case "Ejercicio Extremo (2 veces al día)":
                    tmb = (int)(tmb * 1.9);
                    break;
            }

            this.tmb = tmb;
        }

        void Ir(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Calculando(bmi, tmb));
        }
    }
}