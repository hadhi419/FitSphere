namespace FitSphere.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            btnBackToSignup = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(111, 181);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnBackToSignup
            // 
            btnBackToSignup.BackColor = Color.White;
            btnBackToSignup.FlatAppearance.BorderSize = 0;
            btnBackToSignup.FlatStyle = FlatStyle.Flat;
            btnBackToSignup.ForeColor = Color.OrangeRed;
            btnBackToSignup.Location = new Point(129, 301);
            btnBackToSignup.Name = "btnBackToSignup";
            btnBackToSignup.Size = new Size(200, 23);
            btnBackToSignup.TabIndex = 4;
            btnBackToSignup.Text = "Don't have an account?";
            btnBackToSignup.UseVisualStyleBackColor = false;
            btnBackToSignup.Click += btnBackToLogin_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(145, 265);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(111, 222);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(232, 23);
            txtPassword.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnBackToSignup);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 388);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoOrange_01_02;
            pictureBox1.Location = new Point(117, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 381);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Button btnBackToLogin;
        private TextBox txtEmail;
        private Button btnBackToSignup;
        private Button btnLogin;
        private TextBox txtPassword;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}