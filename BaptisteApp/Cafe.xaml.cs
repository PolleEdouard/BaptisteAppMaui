using BaptisteApp.Models;
using BaptisteApp.ViewModel;



namespace BaptisteApp
{
    public partial class Cafe : ContentPage
    {
        public Cafe()
        {
            InitializeComponent();
            this.BindingContext = new CafeViewModel();
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCoffee = e.CurrentSelection.FirstOrDefault() as Coffee;
            if (selectedCoffee != null)
            {
                await Navigation.PushAsync(new CoffeeDetail(selectedCoffee));
            }

            // Désélectionner l'élément
            ((CollectionView)sender).SelectedItem = null;

        }
    }
}
