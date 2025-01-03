using FitSphere.API;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Apis.Requests.BatchRequest;

namespace FitSphere.Forms
{
    public partial class Ingredients : Form
    {
        string currentUser;

        string ingredient;
        public Ingredients(String username)
        {
            InitializeComponent();
            currentUser = username;
            lblUser.Text = username;

            timer1.Start();
            timer1.Tick += timer1_Tick;
            timer1.Tick += showMeal;

            pctrIngredient.SizeMode = PictureBoxSizeMode.Zoom;
            LoadImageFromJsonResponse();


        }

        private async void LoadImageFromJsonResponse()
        {
            // JSON response string (replace with your actual API call response)





        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void showMeal(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan breakfastStart = new TimeSpan(6, 0, 0); // 6:00 AM
            TimeSpan breakfastEnd = new TimeSpan(10, 0, 0);  // 10:00 AM
            TimeSpan lunchStart = new TimeSpan(12, 0, 0);    // 12:00 PM
            TimeSpan lunchEnd = new TimeSpan(14, 0, 0);      // 2:00 PM
            TimeSpan dinnerStart = new TimeSpan(18, 0, 0);   // 6:00 PM
            TimeSpan dinnerEnd = new TimeSpan(21, 0, 0);     // 9:00 PM

            // Check which meal it is
            if (currentTime.TimeOfDay >= breakfastStart && currentTime.TimeOfDay < breakfastEnd)
            {
                lblMealTime.Text = "It's Breakfast Time!";
            }
            else if (currentTime.TimeOfDay >= lunchStart && currentTime.TimeOfDay < lunchEnd)
            {
                lblMealTime.Text = "It's Lunch Time!";
            }
            else if (currentTime.TimeOfDay >= dinnerStart && currentTime.TimeOfDay < dinnerEnd)
            {
                lblMealTime.Text = "It's Dinner Time!";
            }
            else
            {
                lblMealTime.Text = "It's not meal time right now!";
            }
        }


        private void Ingredients_Load(object sender, EventArgs e)
        {

        }

        private void btnMyRecipes_Click(object sender, EventArgs e)
        {
            MyRecipes myRecipes = new MyRecipes(currentUser);
            myRecipes.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home(currentUser);
            home.Show();
            this.Hide();
        }
        private void btnCalculateValues_Click(object sender, EventArgs e)
        {
            CalcNutritionalVal calcNutritionalVal = new CalcNutritionalVal(currentUser);
            this.Hide();
            calcNutritionalVal.Show();
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            MyRecipes myRecipes = new MyRecipes(currentUser);
            this.Hide();
            myRecipes.Show();
        }

        private void btnRecipes_Click_1(object sender, EventArgs e)
        {
            Recipes recipes = new Recipes(currentUser);
            recipes.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home(currentUser);
            home.Show();
            this.Hide();
        }

        private void btnMyRecipes_Click_1(object sender, EventArgs e)
        {
            MyRecipes myRecipes = new MyRecipes(currentUser);
            myRecipes.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }


        private async void btnSearch_Click(object sender, EventArgs e)
        {
            ingredient = txtIngredient.Text;
            string quantity = txtQuantity.Text;

            // Check if either field is empty
            if (string.IsNullOrEmpty(ingredient) || string.IsNullOrWhiteSpace(quantity))
            {
                MessageBox.Show("Please enter a valid query.");
                return;
            }

            API.getNutritionByIngredient apiCall = new API.getNutritionByIngredient();

            try
            {
                // Await the asynchronous method call
                string response = await apiCall.LoadNutritionByIngredients($"{quantity} {ingredient}");

                // Deserialize the JSON response into a Root object
                fatSecret.classes.Root root = JsonConvert.DeserializeObject<fatSecret.classes.Root>(response);

                //MessageBox.Show(response);

                // Check if the response contains any items
                if (root != null && root.items != null && root.items.Count > 0)
                {
                    fatSecret.classes.Ingredient food = root.items[0]; // Get the first item in the list


                    //"serving_size_g  : " + food.serving_size_g.ToString() + Environment.NewLine +
                    txtCalories.Text = food.calories + Environment.NewLine;
                    txtSugar.Text = food.sugar_g + Environment.NewLine;
                    txtFibre.Text = food.fiber_g + Environment.NewLine;
                    txtSodium.Text = food.sodium_mg + Environment.NewLine;
                    txtPotassium.Text = food.potassium_mg + Environment.NewLine;
                    txtFatSaturated.Text = food.fat_saturated_g + Environment.NewLine;
                    txtTotalFat.Text = food.fat_total_g + Environment.NewLine;
                    txtCholesterol.Text = food.cholesterol_mg + Environment.NewLine;
                    txtProtein.Text = food.protein_g + Environment.NewLine;
                    txtCarb.Text = food.carbohydrates_total_g + Environment.NewLine;
                }
                else
                {
                    MessageBox.Show("Internal Error!", "No valid data found in the API response", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GetPicture getPicture = new GetPicture();


            string jsonResponse = await getPicture.LoadPicture($"Ingredient {ingredient}");


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
                            pctrIngredient.SizeMode = PictureBoxSizeMode.Zoom;
                            pctrIngredient.Image = img;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //int i = 1;
        private async void btnNext_Click(object sender, EventArgs e)
        {
           // i++;

            GetPicture getPicture = new GetPicture();


            string jsonResponse = await getPicture.LoadPicture($"Cooking {ingredient}");


            try
            {
                // Parse JSON
                JObject json = JObject.Parse(jsonResponse);

                // Extract the first result's medium image URL
                string imageUrl = json["results"]?[4]?["urls"]?["regular"]?.ToString();


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
                            pctrIngredient.SizeMode = PictureBoxSizeMode.Zoom;
                            pctrIngredient.Image = img;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateValues_Click_1(object sender, EventArgs e)
        {
            CalcNutritionalVal calcNutritionalVal = new CalcNutritionalVal(currentUser);
            this.Hide();
            calcNutritionalVal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Recipes recipes = new Recipes(currentUser);
            this.Hide();
            recipes.Show(); 
        }
    }
}
