using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitSphere.Forms
{
    public partial class Ingredients : Form
    {
        string currentUser;
        public Ingredients(String username)
        {
            InitializeComponent();
            currentUser = username;
            lblUser.Text = username;

            timer1.Start();
            timer1.Tick += timer1_Tick;
            timer1.Tick += showMeal;

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

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            MyRecipes myRecipes = new MyRecipes(currentUser);
            this.Hide();
            myRecipes.Show();
        }

        private void btnRecipes_Click_1(object sender, EventArgs e)
        {
            MyRecipes myRecipes = new MyRecipes(currentUser);
            myRecipes.Show();
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
            string ingredient = txtIngredient.Text;
            string quantity = txtQuantity.Text;

            // Check if either field is empty
            if (string.IsNullOrWhiteSpace(ingredient) || string.IsNullOrWhiteSpace(quantity))
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

                MessageBox.Show(response);

                // Check if the response contains any items
                if (root != null && root.items != null && root.items.Count > 0)
                {
                    fatSecret.classes.Ingredient food = root.items[0]; // Get the first item in the list

                    txtNutrition.Text =
                        "serving_size_g  : " + food.serving_size_g.ToString() + Environment.NewLine +
                        "Calories : " + food.calories + Environment.NewLine +
                        "sugar_g : " + food.sugar_g + Environment.NewLine +
                        "fiber_g : " + food.fiber_g + Environment.NewLine +
                        "sodium_mg : " + food.sodium_mg + Environment.NewLine +
                        "potassium_mg : " + food.potassium_mg + Environment.NewLine +
                        "fat_saturated_g : " + food.fat_saturated_g + Environment.NewLine +
                        "fat_total_g : " + food.fat_total_g + Environment.NewLine +
                        "cholesterol_mg : " + food.cholesterol_mg + Environment.NewLine +
                        "protein_g : " + food.protein_g + Environment.NewLine +
                        "carbohydrates_total_g : " + food.carbohydrates_total_g;
                }
                else
                {
                    MessageBox.Show("No valid data found in the API response.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



    }
}
