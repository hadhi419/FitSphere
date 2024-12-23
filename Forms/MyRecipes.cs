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
    }
}
