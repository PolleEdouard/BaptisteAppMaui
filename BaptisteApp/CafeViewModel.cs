
/* Modification non fusionnée à partir du projet 'BaptisteApp (net8.0-windows10.0.19041.0)'
Avant :
using System.Collections.Generic;
Après :
using BaptisteApp.Models;
using System.Collections.Generic;
*/

/* Modification non fusionnée à partir du projet 'BaptisteApp (net8.0-android)'
Avant :
using System.Collections.Generic;
Après :
using BaptisteApp.Models;
using System.Collections.Generic;
*/

/* Modification non fusionnée à partir du projet 'BaptisteApp (net8.0-ios)'
Avant :
using System.Collections.Generic;
Après :
using BaptisteApp.Models;
using System.Collections.Generic;
*/
using BaptisteApp.Models;
using System.Collections.ObjectModel;
using System.Text.Json;
/* Modification non fusionnée à partir du projet 'BaptisteApp (net8.0-windows10.0.19041.0)'
Avant :
using System.Threading.Tasks;
using BaptisteApp.Models;
Après :
using System.Threading.Tasks;
*/

/* Modification non fusionnée à partir du projet 'BaptisteApp (net8.0-android)'
Avant :
using System.Threading.Tasks;
using BaptisteApp.Models;
Après :
using System.Threading.Tasks;
*/

/* Modification non fusionnée à partir du projet 'BaptisteApp (net8.0-ios)'
Avant :
using System.Threading.Tasks;
using BaptisteApp.Models;
Après :
using System.Threading.Tasks;
*/


namespace BaptisteApp.ViewModel
{
    public class CafeViewModel
    {
        public ObservableCollection<Coffee> Coffees { get; } = new ObservableCollection<Coffee>();

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
                    Coffees.Add(coffee);
                }
            }
        }
    }
}
