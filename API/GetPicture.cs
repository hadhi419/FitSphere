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
    internal class GetPicture
    {

        public async Task<string> LoadPicture(string query)
        {
            String url = $"https://api.unsplash.com/search/photos/?page=2&query={query}&client_id=n7DjEqnJIsNsVzmlHSH_eaEiNBLIziuVsEgkHK0yqlY&orientation=squarish";
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        //var nutritionData = JsonSerializer.Deserialize<dynamic>(jsonResponse);
                        return jsonResponse;
                    }
                    else
                    {
                        return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                    }
                }
            }
            catch (Exception ex) {
                return null;
            }
            
            
        } 
    }
}
