using BaptisteApp.Models;
namespace BaptisteApp;

public partial class CoffeeDetail : ContentPage
{
	public CoffeeDetail(Coffee coffee)
	{
		InitializeComponent();
		BindingContext = coffee;

    }
    private async void GoCoffeePage(object sender, EventArgs e)
    {
        // Naviguer vers la page qui contient le GIF
        await Navigation.PushAsync(new Cafe());
    }
}