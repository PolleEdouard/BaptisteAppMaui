
using BaptisteApp.Models;
using System.Collections.ObjectModel;
using System.Text.Json;



namespace BaptisteApp.ViewModel
{
    public class CafeViewModel
    {
        public ObservableCollection<Coffee> Coffee { get; } = new ObservableCollection<Coffee>();

        public CafeViewModel()
        {
            Task.Run(() => LoadCoffeeAsync());
        }

        private async Task LoadCoffeeAsync()
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api.sampleapis.com/coffee/hot");
            var coffees = JsonSerializer.Deserialize<List<Coffee>>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (coffees != null)
            {
                foreach (var coffee in coffees)
                {
                    Coffee.Add(coffee);
                }
            }
        }
        public void AddCoffee(Coffee coffee)
        {
            Coffee.Add(coffee);
            Task.Run(() => SaveBeerAsync(coffee));
        }

        private async Task SaveBeerAsync(Coffee coffee)
        {
            var httpClient = new HttpClient();

            var coffeeJson = JsonSerializer.Serialize(coffee);
            var content = new StringContent(coffeeJson, System.Text.Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("https://api.sampleapis.com/coffee/add", content);
        }

    }
}
