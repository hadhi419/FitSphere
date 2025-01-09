namespace FitSphere
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSignup = new Button();
            btnBackLogin = new Button();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Green;
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(143, 299);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(167, 30);
            btnSignup.TabIndex = 13;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += Login_Click;
            // 
            // btnBackLogin
            // 
            btnBackLogin.BackColor = Color.White;
            btnBackLogin.FlatAppearance.BorderSize = 0;
            btnBackLogin.FlatStyle = FlatStyle.Flat;
            btnBackLogin.ForeColor = Color.OrangeRed;
            btnBackLogin.Location = new Point(172, 330);
            btnBackLogin.Name = "btnBackLogin";
            btnBackLogin.Size = new Size(106, 23);
            btnBackLogin.TabIndex = 12;
            btnBackLogin.Text = "Back to Login";
            btnBackLogin.UseVisualStyleBackColor = false;
            btnBackLogin.Click += btnBackLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(113, 173);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(232, 23);
            txtUsername.TabIndex = 0;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 253);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(232, 23);
            txtPassword.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnSignup);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 384);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoOrange_01_021;
            pictureBox1.Location = new Point(113, -31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 381);
            Controls.Add(btnBackLogin);
            Controls.Add(panel1);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign up";
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSignup;
        private Button btnBackLogin;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
