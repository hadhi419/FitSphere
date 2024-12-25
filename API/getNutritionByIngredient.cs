    using fatSecret.classes;
   // using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    using System;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace FitSphere.API
    {
        public class getNutritionByIngredient
        {
        public async Task<string> LoadNutritionByIngredients(string query)
        {
            string baseUrl = "https://api.calorieninjas.com/v1/nutrition";
            string apiKey = "stHkeRImYFarysHM1KXTzg==MV3qsaC140Fa2MZr";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Set API key in headers
                    client.DefaultRequestHeaders.Add("X-Api-Key", apiKey);

                    // Construct the request URL
                    string url = $"{baseUrl}?query={Uri.EscapeDataString(query)}";

                    // Send GET request
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        var nutritionData = JsonSerializer.Deserialize<dynamic>(jsonResponse);
                        return JsonSerializer.Serialize(nutritionData, new JsonSerializerOptions { WriteIndented = true });
                    }
                    else
                    {
                        return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                return $"Request error: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
    }
