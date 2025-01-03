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
    public partial class MyRecipes : Form
    {
        String currentUser;
        public MyRecipes(String username)
        {
            InitializeComponent();

            currentUser = username; ;
            lblUser.Text = username;

            timer1.Start();
            timer1.Tick += timer1_Tick;
            timer1.Tick += showMeal;

        }
        public string mail;

        public MyRecipes(String username, string email)
        {
            InitializeComponent();

            currentUser = username;
            mail = email;
            lblUser.Text = username;

            timer1.Start();
            timer1.Tick += timer1_Tick;
            timer1.Tick += showMeal;

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
            TimeSpan dinnerStart = new TimeSpan(18, 9, 0);   // 6:00 PM
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

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            Home home = new Home(currentUser);
            home.Show();
            this.Hide();
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            Recipes recipes = new Recipes(currentUser);
            this.Hide();
            recipes.Show();
        }


        private void btnIngredients_Click(object sender, EventArgs e)
        {
            Ingredients ingredients = new Ingredients(currentUser);
            this.Hide();
            ingredients.Show();
        }

        private void btnIngredients_Click_1(object sender, EventArgs e)
        {
            Ingredients ingredients = new Ingredients(currentUser);
            this.Hide();
            ingredients.Show();
        }

        private void MyRecipes_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateValues_Click(object sender, EventArgs e)
        {
            CalcNutritionalVal calcNutritionalVal = new CalcNutritionalVal(currentUser);
            this.Hide();
            calcNutritionalVal.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMyRecipeDetails addMyRecipeDetails = new AddMyRecipeDetails(mail);
            addMyRecipeDetails.Show();

        }

        private void addNewRecipe_BackColorChanged(object sender, EventArgs e)
        {

        }

        //private void panel4_MouseHover(object sender, EventArgs e)
        //{
        //    panel4.BackColor = Color.LightGreen;
        //}

        //private void pictureBox1_MouseHover(object sender, EventArgs e)
        //{
        //    panel4.BackColor = Color.LightGreen;
        //}

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.LightGreen;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.LightGreen;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
        }

        private void btnAddNewRecipe_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.LightGreen;
        }

        private void btnAddNewRecipe_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            AddMyRecipeDetails addMyRecipeDetails = new AddMyRecipeDetails(mail);
            addMyRecipeDetails.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AddMyRecipeDetails addMyRecipeDetails = new AddMyRecipeDetails(mail);
            addMyRecipeDetails.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            AddMyRecipeDetails addMyRecipeDetails = new AddMyRecipeDetails(mail);
            addMyRecipeDetails.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            AddMyRecipeDetails addMyRecipeDetails = new AddMyRecipeDetails(mail);
            addMyRecipeDetails.Show();
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Khaki;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Khaki;
        }

        private void btnViewMyRecipes_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Khaki;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
        }

        private void btnViewMyRecipes_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            myRecipesList myRecipesList = new myRecipesList();
            myRecipesList.Show();
            this.Hide(); ;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            myRecipesList myRecipesList = new myRecipesList();
            myRecipesList.Show();
            this.Hide();
        }

        private void btnViewMyRecipes_Click(object sender, EventArgs e)
        {
            myRecipesList myRecipesList = new myRecipesList();
            myRecipesList.Show();
            this.Hide();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnViewMyRecipes_Click_1(object sender, EventArgs e)
        {
            myRecipesList myRecipesList = new myRecipesList();
            myRecipesList.Show();
            this.Hide();
        }
    }
}
