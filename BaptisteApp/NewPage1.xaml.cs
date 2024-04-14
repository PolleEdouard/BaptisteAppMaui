using BaptisteApp.Models;
using BaptisteApp.ViewModel;

namespace BaptisteApp;

public partial class NewPage1 : ContentPage
{
    int count = 0;
    public NewPage1()
    {
        InitializeComponent();
    }
    
    private async void OnAddCoffeeClicked(object sender, EventArgs e)
    {
        var coffee = new Coffee
        {
            title = titleEntry.Text,
            description = descriptionEntry.Text,
            ingredients = ingredientsEntry.Text.Split(',').ToList(),
            image = imageUrlEntry.Text,
            id = GenerateRandomId()
        };

        var viewModel = BindingContext as CafeViewModel;
        viewModel?.AddCoffee(coffee);

        await DisplayAlert("SUPER", "une nouvelle boisson est dans la liste", "OK");
        await Navigation.PopAsync();
    }
    private int GenerateRandomId()
    {
        Random random = new Random();
        return random.Next(); // Génère un entier aléatoire
    }
}
