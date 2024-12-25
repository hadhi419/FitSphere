using fatSecret.Classes;
using FitSphere.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FitSphere.API;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Apis.Requests.BatchRequest;
using fatSecret.classes;

namespace FitSphere.Forms
{
    public partial class RecipeDetails : Form
    {

        String description;
        List<Ingredient1> ingredients;
        Serving servings;
        List<Direction> directions;
        decimal portianSize = 1;

        public RecipeDetails(String description, List<Ingredient1> ingredients, Serving servings, List<Direction> directions,string recipeName)
        {
            InitializeComponent();
            description = description;
            this.ingredients = ingredients;
            this.servings = servings;
            //MessageBox.Show(servings.protein);
            displayIngredients(ingredients);
            displayServings(servings);
            displayDirections(directions);
            //updatePicture(recipeName);





        }

        public async void updatePicture(String recipeName)
        {
            GetPicture getPicture = new GetPicture();   

            string jsonResponse = await getPicture.LoadPicture(recipeName);


            try
            {
                // Parse JSON
                JObject json = JObject.Parse(jsonResponse);

                // Extract the first result's medium image URL
                string imageUrl = json["results"]?[0]?["urls"]?["regular"]?.ToString();


                //textBox1.Text = (jsonResponse);

                if (!string.IsNullOrEmpty(imageUrl))
                {
                    // Download the image
                    using (HttpClient client = new HttpClient())
                    {
                        byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);

                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            // Load the image and set it to PictureBox
                            Image img = Image.FromStream(ms);
                            pictureRecipe.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureRecipe.Image = img;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No image URL found in the JSON response.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        public void displayIngredients(List<Ingredient1> ingredients)
        {
            if (ingredients != null)
            {
                StringBuilder ingredientsStringBuilder = new StringBuilder();

                foreach (var i in ingredients)
                {
                    ingredientsStringBuilder.AppendLine($"{i.ingredient_description} - {i.measurement_description} ({(ParseToDecimal(i.number_of_units)) * portianSize} units)");
                }

                // MessageBox.Show(ingredientsStringBuilder.ToString());
                txtIngredients.Text = ingredientsStringBuilder.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        
        public void displayDirections(List<Direction> directions)
        {
            if (ingredients != null)
            {
                StringBuilder directionsStringBuilder = new StringBuilder();

                foreach (var i in directions)
                {
                    directionsStringBuilder.AppendLine($"{i.direction_number} - {i.direction_description}");
                }

                // MessageBox.Show(ingredientsStringBuilder.ToString());
                txtDirections.Text = directionsStringBuilder.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public async void displayServings(Serving servings)
        {
            if (servings != null)
            {
                txtNutrition.Text =
                    "Calories : " + (ParseToDecimal(servings.calories)) * portianSize + Environment.NewLine +
                    "Calium : " + (ParseToDecimal(servings.calcium)) * portianSize + Environment.NewLine +
                    "Carbohydrate : " + (ParseToDecimal(servings.carbohydrate)) * portianSize + Environment.NewLine +
                    "Cholesterol : " + (ParseToDecimal(servings.cholesterol)) * portianSize + Environment.NewLine +
                    "Fat : " + (ParseToDecimal(servings.fat)) * portianSize + Environment.NewLine +
                    "Fiber : " + (ParseToDecimal(servings.fiber)) * portianSize + Environment.NewLine +
                    "Iron : " + (ParseToDecimal(servings.iron)) * portianSize + Environment.NewLine +
                    "Monounsaturated Fat : " + (ParseToDecimal(servings.monounsaturated_fat)) * portianSize + Environment.NewLine +
                    "Polyunsaturated Fat : " + (ParseToDecimal(servings.polyunsaturated_fat)) * portianSize + Environment.NewLine +
                    "Potassium : " + (ParseToDecimal(servings.potassium)) * portianSize + Environment.NewLine +
                    "Protein : " + (ParseToDecimal(servings.protein)) * portianSize + Environment.NewLine +
                    "Saturated_fat : " + (ParseToDecimal(servings.saturated_fat)) * portianSize + Environment.NewLine +
                    "Serving_size : " + (ParseToDecimal(servings.serving_size)) * portianSize + Environment.NewLine +
                    "Sodium : " + (ParseToDecimal(servings.sodium)) * portianSize + Environment.NewLine +
                    "Sugar : " + (ParseToDecimal(servings.sugar)) * portianSize + Environment.NewLine +
                    "Trans_fat : " + (ParseToDecimal(servings.trans_fat)) * portianSize + Environment.NewLine +
                    "Vitamin_c : " + (ParseToDecimal(servings.vitamin_c)) * portianSize + Environment.NewLine;


            }
            else
            {
                MessageBox.Show("Null");
            }
        }


        public decimal ParseToDecimal(string input)
        {
            if (decimal.TryParse(input, out decimal result))
            {
                return result; // Successfully parsed
            }
            else
            {
                // Handle the case when parsing fails, return 0 or any default value
                return 0m; // Use the 'm' suffix to indicate it's a decimal literal
            }
        }

        private void RecipeDetails_Load(object sender, EventArgs e)
        {

        }

        private void lblRecipeName_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePortion_Click(object sender, EventArgs e)
        {
            portianSize = nmrcPortion.Value;
            displayIngredients(ingredients);
            displayServings(servings);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
