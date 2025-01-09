using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using fireStore;
using FitSphere.Classes;
using fatSecret.Classes;
using Newtonsoft.Json;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace FitSphere.Forms
{
    public partial class myRecipesList : Form
    {
        string mail;
        string currentUser;
        public myRecipesList(string _mail, string _currentUser)
        {
            InitializeComponent();
            mail = _mail;
            this.currentUser = _currentUser;
        }


        private async void btnAllRecipes_Click(object sender, EventArgs e)
        {
            try
            {
                //Home home = new Home();
                string email = mail;
                fireStore.FireStoreAPI firestore = new fireStore.FireStoreAPI();

                // MessageBox.Show(type);

                string response = await firestore.getRecipes(currentUser);
                MessageBox.Show(response);

                // Deserialize JSON response into RecipeApiResponse
                List<MyRecipeModel> apiResponse = JsonConvert.DeserializeObject<List<MyRecipeModel>>(response);


                if (apiResponse != null)
                {
                    DisplayRecipes(apiResponse);

                }
                else
                {
                    MessageBox.Show("No recipes Found");
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void DisplayRecipes(List<MyRecipeModel> recipes)
        {
            // Clear existing controls from the FlowLayoutPanel
            flowLayoutRecipes.Controls.Clear();

            foreach (var recipe in recipes)
            {
                // Create a new button for each recipe
                var recipeButton = new System.Windows.Forms.Button
                {
                    Text = recipe.RecipeName,
                    Tag = recipe, // Store the recipe object in the button's Tag
                    Width = 1070,
                    Height = 50,
                    Margin = new Padding(10),
                    BackColor = Color.White,
                    ForeColor = Color.OrangeRed,
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft, // Left-align the text
                    FlatStyle = FlatStyle.Flat, // Set FlatStyle to Flat
                                                // Set margin of 10 pixels on all sides
                };

                recipeButton.FlatAppearance.BorderSize = 1;       // Set border thickness to 1
                recipeButton.FlatAppearance.BorderColor = Color.OrangeRed; // Set the border color
                recipeButton.FlatAppearance.MouseOverBackColor = Color.LightGray; // Change background on hover
                recipeButton.FlatAppearance.MouseDownBackColor = Color.Gray;

                // recipeButton.Click += RecipeButton_Click;


                // Attach Click Event
                recipeButton.Click += RecipeButton_Click;

                // Add the button to the FlowLayoutPanel
                flowLayoutRecipes.Controls.Add(recipeButton);
            }


        }


        private async void RecipeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the sender is a button and retrieve the recipe name
                if (sender is System.Windows.Forms.Button recipeButton)
                {
                    string recipeName = recipeButton.Text; // Get the recipe name from the button text

                    // Retrieve the user's email
                    // Home home = new Home();
                    string email = mail;

                    // Firestore API instance
                    fireStore.FireStoreAPI firestore = new fireStore.FireStoreAPI();

                    // Retrieve the specific recipe using email and recipe name
                    string response = await firestore.getMyRecipe(currentUser, recipeName);

                    if (!string.IsNullOrEmpty(response))
                    {
                        // Deserialize the response into a list of recipes
                        List<MyRecipeModel> recipes = JsonConvert.DeserializeObject<List<MyRecipeModel>>(response);

                        if (recipes != null && recipes.Count > 0)
                        {
                            MyRecipeModel selectedRecipe = recipes.FirstOrDefault(); // Get the first matching recipe

                            if (selectedRecipe != null)
                            {
                                // Open RecipeDetails form and populate with recipe information
                                MyRecipeDetails recipeDetails = new MyRecipeDetails(selectedRecipe);


                                recipeDetails.Show();
                            }
                            else
                            {
                                MessageBox.Show("No details found for the selected recipe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No matching recipes found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve recipe details. No response from Firestore.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid recipe selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void myRecipesList_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MyRecipes myRecipes = new MyRecipes(currentUser, mail);
            myRecipes.Show();
            this.Hide();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {

            flowLayoutRecipes.Controls.Clear();
            try
            {
                //Home home = new Home();
                //string email = mail;

                string query = txtQuery.Text.ToLower();
                fireStore.FireStoreAPI firestore = new fireStore.FireStoreAPI();

                // MessageBox.Show(type);

                string response = await firestore.searchRecipes(currentUser, query);
                MessageBox.Show(response);

                // Deserialize JSON response into RecipeApiResponse
                List<MyRecipeModel> apiResponse = JsonConvert.DeserializeObject<List<MyRecipeModel>>(response);


                if (apiResponse != null)
                {
                    DisplayRecipes(apiResponse);

                }
                else
                {
                    MessageBox.Show("No recipes Found");
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
