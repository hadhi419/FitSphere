using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitSphere.Classes
{

    public class MyRecipeModel
    {
        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Directions")]
        public string Directions { get; set; }
        
        [JsonProperty("Email")]
        public string Email { get; set; }
        
        [JsonProperty("Ingredients")]
        public string Ingredients { get; set; }
        
        [JsonProperty("RecipeName")]
        public string RecipeName { get; set; }
    }
}
