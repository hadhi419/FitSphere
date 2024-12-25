using FitSphere.Classes;
using FitSphere.Forms;
using System.Security.Cryptography;
using Google.Cloud.Firestore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FitSphere
{
    public partial class SignUp : Form
    {
        public SignUp()
        {

            InitializeComponent();
            // this.WindowState = FormWindowState.Maximized;
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private async void Login_Click(object sender, EventArgs e)
        {
            try
            {
                var db = FireStoreHelper.Database;
                if (!isValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Enter a valid Email");

                }
                else
                {
                    if (ifUserAlreadyExist())
                    {
                        MessageBox.Show("Username Already Taken");
                    }
                    else
                    {
                        if (ifEmailAlreadyregitered())
                        {
                            MessageBox.Show("Email Already registered");
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtUsername.Text))
                            {

                                MessageBox.Show("Every field is required!");
                            }
                            else
                            {
                                var data = GetVariables();
                                DocumentReference docRef = db.Collection("Userdata").Document(data.Email);
                                await docRef.SetAsync(data);
                                Home home = new Home(data.Username);
                                this.Hide();
                                home.Show();
                            }
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }

        private UserData GetVariables()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            String hashedPassword = Hashpassword(password);

            String email = txtEmail.Text.Trim();
            return new UserData()
            {
                Username = username,
                Password = hashedPassword,
                Email = email
            };

        }

        public bool ifUserAlreadyExist()
        {
            String username = txtUsername.Text.Trim();
            var db = FireStoreHelper.Database;

            Query query = db.Collection("Userdata").WhereEqualTo("Username", username);

            QuerySnapshot querysnapshot = query.GetSnapshotAsync().Result;

            return querysnapshot.Documents.Count > 0;
        }

        public bool ifEmailAlreadyregitered()
        {
            string email = txtEmail.Text; // Trim any whitespace
            var db = FireStoreHelper.Database;

            // Query the "Userdata" collection to find a document where the "Email" field matches the given email
            Query query = db.Collection("Userdata").WhereEqualTo("Email", email);

            // Get the snapshot of the query results
            QuerySnapshot querySnapshot = query.GetSnapshotAsync().Result;

            // Check if any documents were returned (i.e., if the email already exists)
            return querySnapshot.Documents.Count > 0;
        }

        private string Hashpassword(String password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }



        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        private bool isValidEmail(String email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
