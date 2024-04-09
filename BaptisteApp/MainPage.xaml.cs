namespace BaptisteApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void GoGifPage(object sender, EventArgs e)
        {
            // Naviguer vers la page qui contient le GIF
            await Navigation.PushAsync(new GifPage());
        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            rotatingLabel.Rotation = value;
            displayLabel.Text = String.Format("La valeur est {0}", value);
        }

    }

}
