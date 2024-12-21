namespace FitSphere.Forms
{
    partial class Home
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
            button1 = new Button();
            panel1 = new Panel();
            lblUser = new Label();
            btnCalculateValues = new Button();
            btnIngredients = new Button();
            btnRecipes = new Button();
            btnMyRecipes = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(1, 28);
            button1.Name = "button1";
            button1.Size = new Size(160, 48);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(btnCalculateValues);
            panel1.Controls.Add(btnIngredients);
            panel1.Controls.Add(btnRecipes);
            panel1.Controls.Add(btnMyRecipes);
            panel1.Location = new Point(1, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 50);
            panel1.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.DarkOrange;
            lblUser.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(1015, 19);
            lblUser.Margin = new Padding(3);
            lblUser.MaximumSize = new Size(140, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(41, 15);
            lblUser.TabIndex = 2;
            lblUser.Text = "label1";
            // 
            // btnCalculateValues
            // 
            btnCalculateValues.BackColor = Color.White;
            btnCalculateValues.FlatAppearance.BorderSize = 0;
            btnCalculateValues.FlatStyle = FlatStyle.Flat;
            btnCalculateValues.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateValues.ForeColor = Color.FromArgb(128, 255, 128);
            btnCalculateValues.Location = new Point(640, 0);
            btnCalculateValues.Name = "btnCalculateValues";
            btnCalculateValues.Size = new Size(160, 50);
            btnCalculateValues.TabIndex = 5;
            btnCalculateValues.Text = "Calculate Nutritional Values";
            btnCalculateValues.UseVisualStyleBackColor = false;
            // 
            // btnIngredients
            // 
            btnIngredients.BackColor = Color.White;
            btnIngredients.FlatAppearance.BorderSize = 0;
            btnIngredients.FlatStyle = FlatStyle.Flat;
            btnIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngredients.ForeColor = Color.FromArgb(128, 255, 128);
            btnIngredients.Location = new Point(480, 0);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(160, 50);
            btnIngredients.TabIndex = 4;
            btnIngredients.Text = "Ingredients";
            btnIngredients.UseVisualStyleBackColor = false;
            // 
            // btnRecipes
            // 
            btnRecipes.BackColor = Color.White;
            btnRecipes.FlatAppearance.BorderSize = 0;
            btnRecipes.FlatStyle = FlatStyle.Flat;
            btnRecipes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecipes.ForeColor = Color.FromArgb(128, 255, 128);
            btnRecipes.Location = new Point(320, 0);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(160, 50);
            btnRecipes.TabIndex = 3;
            btnRecipes.Text = "Recipes";
            btnRecipes.UseVisualStyleBackColor = false;
            // 
            // btnMyRecipes
            // 
            btnMyRecipes.BackColor = Color.White;
            btnMyRecipes.FlatAppearance.BorderSize = 0;
            btnMyRecipes.FlatStyle = FlatStyle.Flat;
            btnMyRecipes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyRecipes.ForeColor = Color.FromArgb(128, 255, 128);
            btnMyRecipes.Location = new Point(160, 0);
            btnMyRecipes.Name = "btnMyRecipes";
            btnMyRecipes.Size = new Size(160, 50);
            btnMyRecipes.TabIndex = 2;
            btnMyRecipes.Text = "My Recipes";
            btnMyRecipes.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-5, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1144, 28);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(54, 13);
            label1.TabIndex = 3;
            label1.Text = "fitSphere";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bg_01_01;
            pictureBox1.Location = new Point(-1, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1138, 534);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 609);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximumSize = new Size(1152, 648);
            Name = "Home";
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button btnCalculateValues;
        private Button btnIngredients;
        private Button btnRecipes;
        private Button btnMyRecipes;
        private Label lblUser;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}