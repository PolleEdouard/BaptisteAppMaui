namespace BaptisteApp;

public partial class GifPage : ContentPage
{
    public GifPage()
    {
        InitializeComponent();
    }

    private async void GoHomePage(object sender, EventArgs e)
    {
        // Utilisez Navigation.PopAsync pour revenir � la page pr�c�dente
        await Navigation.PopAsync();
    }
}