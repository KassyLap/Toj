namespace Toj
{
    public partial class Genero : ContentPage
    {
        private string generoSeleccionado;
        private int ageValue;

        public Genero(int ageValue)
        {
            InitializeComponent();
            this.ageValue = ageValue; // Asigna el valor de ageValue recibido como parámetro a la variable de clase ageValue
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.IsChecked)
            {
                generoSeleccionado = radioButton.Content.ToString();
            }
        }

        void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Altura(generoSeleccionado, ageValue));
        }
    }
}
