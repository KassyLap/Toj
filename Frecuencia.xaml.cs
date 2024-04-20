namespace Toj
{
    public partial class Frecuencia : ContentPage
    {
        private string generoSeleccionado;
        private int ageValue;
        private double weightInKg;
        private double heightInMeters;
        private double bmi;
        private string nivelEjercicioSeleccionado;

        public List<string> Ejercicios { get; set; }

        public string ValorSeleccionado
        {
            get => nivelEjercicioSeleccionado;
            set
            {
                nivelEjercicioSeleccionado = value;
                OnPropertyChanged(nameof(nivelEjercicioSeleccionado));
            }
        }

        public Frecuencia(double bmi, double weightInKg, double heightInMeters, string generoSeleccionado, int ageValue)
        {
            InitializeComponent();
            this.bmi = bmi;
            this.weightInKg = weightInKg;
            this.heightInMeters = heightInMeters;
            this.generoSeleccionado = generoSeleccionado;
            this.ageValue = ageValue;

            Ejercicios = new List<string>
            {
                "Poco o ningún ejercicio",
                "Ejercicio Ligero (1-3 días)",
                "Ejercicio Moderado (3-5 días)",
                "Ejercicio Fuerte (6-7 días)",
                "Ejercicio Extremo (2 veces al día)"
            };
            this.BindingContext = this;
            ValorSeleccionado = Ejercicios.FirstOrDefault();
        }

        void Irr(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Objetivos(bmi,  nivelEjercicioSeleccionado,  weightInKg,  heightInMeters,  generoSeleccionado,  ageValue));
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.IsChecked)
            {
                ValorSeleccionado = radioButton.Content.ToString();
            }
        }
    }
}
