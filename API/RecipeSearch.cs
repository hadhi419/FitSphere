using fatSecret.APICalls;
using fatSecret.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;



namespace FitSphere.API
{
    internal class RecipeSearch
    {
        Oauth oauth = new Oauth();

        string consumerKey = "e415303b83a74a8ab6f73f559eb53584";
        string consumerSecret = "0c48c1211d734704bebf853f2dc7234d";
        string accessToken = "";
        string accessSecret = "";
        string requestUrl = "https://platform.fatsecret.com/rest/";

        public async Task<RecipeApiResponse> LoadRecipes(string search, string sortingMethod, string type)
        {
            try
            {
               // MessageBox.Show(type);
                // Step 1: OAuth Parameters
                string oauthTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
                string oauthNonce = Guid.NewGuid().ToString("N");
                string oauthVersion = "1.0";
                string oauthSignatureMethod = "HMAC-SHA1";



                // Step 2: API Parameters
                var parameters = new Dictionary<string, string>
            {
            { "oauth_consumer_key", consumerKey },
            { "oauth_signature_method", oauthSignatureMethod },
            { "oauth_timestamp", oauthTimestamp },
            { "oauth_nonce", oauthNonce },
            { "format", "json" },
            { "oauth_version", oauthVersion },
            { "method", "recipes.search.v3" },
            { "search_expression", search },
            { "sort_by",sortingMethod },
            { "max_results","50" },
            { "recipe_types",type },
            {"recipe_types_matchall","true" }
            };

                // Step 3: Normalize Parameters
                string normalizedParams = oauth.NormalizeParameters(parameters);

                // Step 4: Generate Signature Base String
                string httpMethod = "GET";
                string baseString = $"{httpMethod.ToUpper()}&{Uri.EscapeDataString(requestUrl)}&{Uri.EscapeDataString(normalizedParams)}";

                // Step 5: Generate OAuth Signature
                string signingKey = $"{Uri.EscapeDataString(consumerSecret)}&{Uri.EscapeDataString(accessSecret)}";
                string oauthSignature = oauth.GenerateSignature(baseString, signingKey);

                // Add Signature to Parameters
                parameters.Add("oauth_signature", oauthSignature);


                // Step 6: Build Query String
                string queryString = string.Join("&", parameters.Select(kvp => $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value)}"));

                // Step 7: Make API Request
                var client = new RestClient($"{requestUrl}?{queryString}");
                var request = new RestRequest();
                request.Method = Method.Get;

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    // Deserialize JSON response
                    var jsonResponse = JsonConvert.DeserializeObject(response.Content);

                    if (response.IsSuccessful)
                    {
                        // Deserialize JSON response into RecipeApiResponse
                        RecipeApiResponse apiResponse = JsonConvert.DeserializeObject<RecipeApiResponse>(response.Content);

                        //MessageBox.Show(jsonResponse.ToString());
                        // Display recipes as buttons
                        if (apiResponse?.recipes?.recipe != null)
                        {
                            return apiResponse;

                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;

            }
            return null;
        }
    }
}
