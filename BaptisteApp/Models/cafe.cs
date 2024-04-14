namespace BaptisteApp.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Coffee
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> ingredients { get; set; }
        public string image { get; set; }
        public int id { get; set; }

        internal static void Add(ObservableCollection<Coffee> coffees)
        {
            throw new NotImplementedException();
        }
    }
}
