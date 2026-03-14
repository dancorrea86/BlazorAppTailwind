using System.Text.Json;
using BlazorAppTailwind.Models;

namespace BlazorAppTailwind.Service
{
    public class StarshipRepository
    {
        public static void SaveStarship(Starship starship)
        {
            string filePath = "products.json";

            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string? json = JsonSerializer.Serialize(starship, options);

            File.WriteAllText(filePath, json);
        }

        public static List<Starship> GetStarships()
        {
            
            string jsonFilePath = "products.json";

            string jsonString = File.ReadAllText(jsonFilePath);

            List<Starship> starships = JsonSerializer.Deserialize<List<Starship>>(jsonString);

            return starships;
        }
    }
}
