using fatSecret.APICalls;
using fatSecret.classes;
using fatSecret.Classes;
using Google.Api.Gax.Grpc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitSphere.Forms
{
    public partial class CalcNutritionalVal : Form
    {
        string currentUser;
        public CalcNutritionalVal(String username)
        {

            InitializeComponent();
            //InitializeComponent();
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

        private void CalcNutritionalVal_Load(object sender, EventArgs e)
        {

        }




        private void lblMealTime_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
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

        private void btnRecipes_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Recipes recipes = new Recipes(currentUser);
            recipes.Show();
        }

        private void btnIngredients_Click_1(object sender, EventArgs e)
        {
            Ingredients ingredients = new Ingredients(currentUser);
            this.Hide();
            ingredients.Show();
        }

        double calories = 0;
        double sugar_g = 0;
        double fiber_g = 0;
        double sodium_mg = 0;
        double potassium_mg = 0;
        double fat_saturated_g = 0;
        double fat_total_g = 0;
        double cholesterol_mg = 0;
        double protein_g = 0;
        double carbohydrates_total_g = 0;

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            addIngerdientToLayout();
            string ingredient = txtIngredient.Text;
            string quantity = "100g";

            // Check if either field is empty
            if (string.IsNullOrWhiteSpace(ingredient) || string.IsNullOrWhiteSpace(quantity))
            {
                MessageBox.Show("Please enter a valid Ingredient. (ex -: 100g onion )", "Oh! Look closely!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                    calories = calories + Convert.ToDouble(food.calories);
                    sugar_g = sugar_g + Convert.ToDouble(food.sugar_g);
                    fiber_g = fiber_g + Convert.ToDouble(food.fiber_g);
                    sodium_mg = sodium_mg + Convert.ToDouble(food.sodium_mg);
                    potassium_mg = potassium_mg + Convert.ToDouble(food.potassium_mg);
                    fat_saturated_g = fat_saturated_g + Convert.ToDouble(food.fat_saturated_g);
                    fat_total_g = fat_total_g + Convert.ToDouble(food.fat_total_g);
                    cholesterol_mg = cholesterol_mg + Convert.ToDouble(food.cholesterol_mg);
                    protein_g = protein_g + Convert.ToDouble(food.protein_g);
                    carbohydrates_total_g = carbohydrates_total_g + Convert.ToDouble(food.carbohydrates_total_g);

                    txtCalories.Text = calories.ToString();
                    txtSugar.Text = sugar_g.ToString();
                    txtFibre.Text = fiber_g.ToString();
                    txtSodium.Text = sodium_mg.ToString();
                    txtPotassium.Text = potassium_mg.ToString();
                    txtFatSaturated.Text = fat_saturated_g.ToString();
                    txtTotalFat.Text = fat_total_g.ToString();
                    txtCholesterol.Text = cholesterol_mg.ToString();
                    txtProtein.Text = protein_g.ToString();
                    txtCarb.Text = carbohydrates_total_g.ToString();
                }
                else
                {
                    MessageBox.Show("Internal Error!", "API call error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private async void addIngerdientToLayout()
        {
            try
            {
                var ingredientButton = new System.Windows.Forms.Button
                {
                    Text = txtIngredient.Text,
                    //Tag = recipe, // Store the recipe object in the button's Tag
                    Width = 1070,
                    Height = 30,
                    Margin = new Padding(10),
                    BackColor = Color.Tomato,
                    ForeColor = Color.White,
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft, // Left-align the text
                    FlatStyle = FlatStyle.Flat, // Set FlatStyle to Flat
                                                // Set margin of 10 pixels on all sides
                };

                flowLayoutIngredients.Controls.Add(ingredientButton);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {




        }
    }
}
