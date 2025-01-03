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
namespace FitSphere.Forms
{
    public partial class myRecipesList : Form
    {
        public myRecipesList()
        {
            InitializeComponent();
        }

        private async void btnAllRecipes_Click(object sender, EventArgs e)
        {
            try
            {
                fireStore.FireStoreAPI firestore = new fireStore.FireStoreAPI();

                // MessageBox.Show(type);

                string response = await firestore.getRecipes("hadhi@gmail.com");
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
            catch (Exception ex) { 
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
                    Text = recipe.RecipeName ,
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

               // recipeButton.Click += RecipeButton_Click;


                // Attach Click Event
                // recipeButton.Click += RecipeButton_Click;

                // Add the button to the FlowLayoutPanel
                flowLayoutRecipes.Controls.Add(recipeButton);
            }


        }
    }
}
