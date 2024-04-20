namespace Toj
{
    public partial class Altura : ContentPage
    {
        private string generoSeleccionado;
        private int ageValue;

        public Altura(string generoSeleccionado, int ageValue)
        {
            InitializeComponent();
            this.generoSeleccionado = generoSeleccionado; // Asigna generoSeleccionado recibido como parámetro a la variable de clase
            this.ageValue = ageValue; // Asigna ageValue recibido como parámetro a la variable de clase
        }

        void ImageButton_Clicked(object sender, EventArgs e)
        {
            var heightInCentimeters = heightSlider.Value;
            var heightInMeters = heightInCentimeters / 100;

            // Pasa generoSeleccionado, ageValue y heightInMeters a la página "TallaPeso"
            Navigation.PushAsync(new TallaPeso(heightInMeters, generoSeleccionado, ageValue));
        }
    }
}
