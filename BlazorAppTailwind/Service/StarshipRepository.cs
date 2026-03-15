using BlazorAppTailwind.Models;
using System.Text.Json;

namespace BlazorAppTailwind.Service
{
    public class StarshipRepository
    {
        public static void SaveStarship(Starship starship)
        {
            string filePath = "products.json";

            string jsonString = File.ReadAllText(filePath);

            List<Starship> starships;

            if (string.IsNullOrWhiteSpace(jsonString))
            {
                starships = new List<Starship>();
            }
            else
            {
                starships = JsonSerializer.Deserialize<List<Starship>>(jsonString) ?? new List<Starship>();
            }
             

            if (starships.Any())
            {
                int lastID = starships.Any() ? starships.Max(x => x.ID) : 0;
   
                starship.ID = lastID + 1;
            }
            else
            {
                starship.ID = 0;
            }

            starships.Add(starship);

            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string? json = JsonSerializer.Serialize(starships, options);

            File.WriteAllText(filePath, json);
        }

        public static List<Starship> GetStarships()
        {
            
            string jsonFilePath = "products.json";

            string jsonString = File.ReadAllText(jsonFilePath);

            List<Starship> starships;

            if (string.IsNullOrWhiteSpace(jsonString))
            {
                starships = new List<Starship>();
            }
            else
            {
                starships = JsonSerializer.Deserialize<List<Starship>>(jsonString) ?? new List<Starship>();
            }

            return starships;
        }

        public static List<Starship> DeleteStarships(Starship ship)
        {

            string jsonFilePath = "products.json";

            string jsonString = File.ReadAllText(jsonFilePath);

            List<Starship> starships = JsonSerializer.Deserialize<List<Starship>>(jsonString);

            foreach (Starship starship in starships)
            {
                if (starship.ID == ship.ID)
                {
                    starships.Remove(starship);
                    break;
                }
            }

            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string? json = JsonSerializer.Serialize(starships, options);

            File.WriteAllText(jsonFilePath, json);

            return starships;
        }
    }
}
