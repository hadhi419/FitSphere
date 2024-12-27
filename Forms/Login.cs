using FitSphere.Classes;
using Google.Cloud.Firestore;
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
    public partial class Login : Form
    {
        public Login()
        {


            InitializeComponent();
            txtEmail.Focus();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String email = txtEmail.Text;
                string password = txtPassword.Text;
                var db = FireStoreHelper.Database;

                DocumentReference docRef = db.Collection("Userdata").Document(email);
                UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

                if (data != null)
                {
                    if (VerifyPassword(password, data.Password))
                    {
                      
                        Home home = new Home(data.Username, data.Email);
     
                        this.Hide();
                        home.Show();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect password!");
                    }
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex);
            }
        }

        private bool VerifyPassword(String enteredPassword, String storedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedPassword);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
