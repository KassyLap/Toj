namespace Toj
{
    public partial class Edad : ContentPage
    {
        private int ageValue; // Variable de clase para almacenar la edad

        public Edad()
        {
            InitializeComponent();
        }

        void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            ageValue = Convert.ToInt32(ageSlider.Value); // Convierte el valor del Slider a int
            Navigation.PushAsync(new Genero(ageValue)); // Pasa la edad a la página "Genero"
        }
    }
}
