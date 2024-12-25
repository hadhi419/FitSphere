using fatSecret.APICalls;
using fatSecret.Classes;
using FitSphere.API;
using Newtonsoft.Json;

namespace FitSphere.Forms
{
    public partial class Recipes : Form
    {
        string currentUser;
        decimal servingSize = 1;
        List<Ingredient1> ingredients;
        Serving servings;
        public Recipes(String username)
        {
            InitializeComponent();
            currentUser = username;
            lblUser.Text = username;

            timer1.Start();
            timer1.Tick += timer1_Tick;
            timer1.Tick += showMeal;



        }

        private void Recipes_Load(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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



        private async void btnSearch_Click(object sender, EventArgs e)
        {

            RecipeSearch recipeSearch = new RecipeSearch();
            var response = await recipeSearch.LoadRecipes(txtSearch.Text);

            if (response == null)
            {
                MessageBox.Show("Response is null!");
                return;
            }

            // Check if the 'recipes' object is populated
            if (response?.recipes?.recipe == null)
            {
                MessageBox.Show("No recipes found!");
            }
            else
            {

                DisplayRecipes(response.recipes.recipe);
            }
        }


        private void DisplayRecipes(List<Recipe> recipes)
        {
            // Clear existing controls from the FlowLayoutPanel
            flowLayoutRecipes.Controls.Clear();

            foreach (var recipe in recipes)
            {
                // Create a new button for each recipe
                var recipeButton = new System.Windows.Forms.Button
                {
                    Text = recipe.recipe_name,
                    Tag = recipe, // Store the recipe object in the button's Tag
                    Width = 1070,
                    Height = 50,
                    Margin = new Padding(10),
                    BackColor = Color.Tomato,
                    ForeColor = Color.White,
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft, // Left-align the text
                    FlatStyle = FlatStyle.Flat, // Set FlatStyle to Flat
                                                // Set margin of 10 pixels on all sides
                };

                recipeButton.Click += RecipeButton_Click;


                // Attach Click Event
                // recipeButton.Click += RecipeButton_Click;

                // Add the button to the FlowLayoutPanel
                flowLayoutRecipes.Controls.Add(recipeButton);
            }


        }
        RecipeDetails recipeDetails;

        private async void RecipeButton_Click(object sender, EventArgs e)
        {
            // Get the button and the associated recipe
            if (sender is Button recipeButton && recipeButton.Tag is Recipe recipe)
            {
                // Ensure recipe_ingredients and its ingredient list are not null
                string nutrition = "No ingredients available.";

                // Display recipe details in a TextBox
                String description =

                    $"Description: {recipe.recipe_description}\n\n" + Environment.NewLine +
                    $"Total Calories: {recipe.recipe_nutrition.calories}\n\n+" + Environment.NewLine +
                    $"Recipe Id: {recipe.recipe_id}";



                GetRecipeById getRecipeById = new GetRecipeById();
                var jsonResponse = await getRecipeById.LoadIngredients(recipe.recipe_id);

                if (jsonResponse?.recipe != null)
                {
                    // Extract ingredients from the response
                    ingredients = jsonResponse.recipe.ingredients?.ingredient;
                    servings = jsonResponse.recipe.serving_sizes?.serving;




                    recipeDetails = new RecipeDetails(description, ingredients, servings);
                    recipeDetails.txtDescription.Text = description;
                    recipeDetails.lblRecipeName.Text = recipe.recipe_name;

                    recipeDetails.Show();






                    //txtNutritions.Text = "Carbohydrate: " + servings.carbohydrate + Environment.NewLine +
                    //"Calories: " + servings.calories;



                }
                else
                {
                    MessageBox.Show("No ingredients found.");
                }
            }
            else
            {
                MessageBox.Show("Recipe data not found in response.");
            }



        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            Ingredients ingredients = new Ingredients(currentUser);
            this.Hide();
            ingredients.Show();
        }
    }
}
