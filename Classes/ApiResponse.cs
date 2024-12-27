using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitSphere.Classes
{
    public class Recipe
{
    [JsonProperty("grams_per_portion")]
    public string GramsPerPortion { get; set; }

    // Include other properties if necessary
}

public class ApiResponse
{
    [JsonProperty("recipe")]
    public Recipe Recipe { get; set; }
}

}
