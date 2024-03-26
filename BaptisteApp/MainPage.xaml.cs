namespace BaptisteApp
{
    public partial class MainPage : ContentPage
    {
        private object videoPlayer;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void GoGifPage(object sender, EventArgs e)
        {
            // Naviguer vers la page qui contient le GIF
            await Navigation.PushAsync(new GifPage());
        }
       

        private void PlayButton_Clicked(object sender, EventArgs e)
        {
            videoPlayer.Play();
        }

        private void PauseButton_Clicked(object sender, EventArgs e)
        {
            videoPlayer.Pause();
        }
    }
}

}
