using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitSphere.Classes;
using FitSphere.Forms;
using System.Security.Cryptography;
using Google.Cloud.Firestore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FitSphere.Forms
{
    public partial class AddMyRecipeDetails : Form
    {
        public string email;
        public AddMyRecipeDetails(string mail)
        {
            InitializeComponent();
            email = "hadhi@gmail.com";
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var db = FireStoreHelper.Database;



                if (String.IsNullOrEmpty(txtDirections.Text) || String.IsNullOrEmpty(txtIngredients.Text) || String.IsNullOrEmpty(txtRecipeName.Text) || String.IsNullOrEmpty(txtDescription.Text))
                {

                    MessageBox.Show("Every field is required!");
                }
                else
                {
                    var data = GetVariables();
                    DocumentReference docRef = db.Collection("Recipes").Document(data.RecipeName);
                    await docRef.SetAsync(data);
                    MessageBox.Show("Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }

        public MyRecipe GetVariables()
        {
            string recipeName = txtRecipeName.Text;
            string recipeDescirption = txtDescription.Text;
            string recipeIngredients = txtIngredients.Text;
            string recipeDirections = txtDirections.Text;
            string Email = email;

            return new MyRecipe
            {
                RecipeName = recipeName,
                Description = recipeDescirption,
                Ingredients = recipeIngredients,
                Directions = recipeDirections,
                Email = Email
            };
        }

        private void AddMyRecipeDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
