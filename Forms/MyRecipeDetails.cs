using FitSphere.Classes;
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
    public partial class MyRecipeDetails : Form
    {

        MyRecipeModel Recipe;
        public MyRecipeDetails(MyRecipeModel _recipe)
        {
            InitializeComponent();
            Recipe = _recipe;
        }

        private void MyRecipe_Load(object sender, EventArgs e)
        {

            txtDescription.Text = Recipe.Description;
            txtRecipeName.Text = Recipe.RecipeName;
            txtIngredientsNeeded.Text = Recipe.Ingredients;
            txtDirections.Text = Recipe.Directions;

        }
    }
}
