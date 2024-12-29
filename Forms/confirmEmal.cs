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
using System;
using System.Net.Mail;
using System.Net;

namespace FitSphere.Forms
{
    public partial class confirmEmal : Form
    {
        UserData userData;
        String email;
        int givenOTP;

        public confirmEmal(String mail, UserData data)
        {

            int givenOTP;

            InitializeComponent();
            userData = data;
            email = mail;

            
        }

        private void confirmEmal_Load(object sender, EventArgs e)
        {

        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            givenOTP = random.Next();
            string givenOtpString = givenOTP.ToString();

            string fromEmail = "321mohomedhadhi@gmail";
            string toEmail = email;
            string subject = "Fitsphere confirmation";
            string body = givenOtpString;

            // Configure SMTP Client
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, "Easyway@123"),
                EnableSsl = true,
            };

            // Create MailMessage
            MailMessage mailMessage = new MailMessage(fromEmail, toEmail, subject, body);



            // Send email
            smtpClient.Send(mailMessage);

            MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (txtOTP.Text == givenOtpString)
            {

                var db = FireStoreHelper.Database;

                DocumentReference docRef = db.Collection("Userdata").Document(userData.Email);
                await docRef.SetAsync(userData);
                Home home = new Home(userData.Username);
                this.Hide();
                home.Show();
            }
        }
    }
}
