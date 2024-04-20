namespace Toj
{
    public partial class TallaPeso : ContentPage
    {
        private string generoSeleccionado;
        private int ageValue;
        public double heightInMeters { get; private set; }

        public TallaPeso(double heightInMeters, string generoSeleccionado, int ageValue)
        {
            InitializeComponent();
            this.heightInMeters = heightInMeters;
            this.generoSeleccionado = generoSeleccionado;
            this.ageValue = ageValue;
        }

        void Ir(object sender, EventArgs e)
        {
            var weightInKg = weightSlider.Value;

            var bmi = weightInKg / (heightInMeters * heightInMeters);

            Navigation.PushAsync(new Frecuencia(bmi, weightInKg, heightInMeters, generoSeleccionado, ageValue));
        }
    }
}
