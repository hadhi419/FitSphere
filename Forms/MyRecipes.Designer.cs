namespace FitSphere.Forms
{
    partial class MyRecipes
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
            components = new System.ComponentModel.Container();
            btnHome = new Button();
            panel1 = new Panel();
            lblUser = new Label();
            btnCalculateValues = new Button();
            btnIngredients = new Button();
            btnRecipes = new Button();
            btnMyRecipes = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblMealTime = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            btnViewMyRecipes = new Button();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            btnAddNewRecipe = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.OrangeRed;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(-5, 26);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(160, 50);
            btnHome.TabIndex = 4;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(btnCalculateValues);
            panel1.Controls.Add(btnIngredients);
            panel1.Controls.Add(btnRecipes);
            panel1.Controls.Add(btnMyRecipes);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-5, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 50);
            panel1.TabIndex = 5;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.OrangeRed;
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
            btnCalculateValues.BackColor = Color.OrangeRed;
            btnCalculateValues.FlatAppearance.BorderSize = 0;
            btnCalculateValues.FlatStyle = FlatStyle.Flat;
            btnCalculateValues.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateValues.ForeColor = Color.White;
            btnCalculateValues.Location = new Point(640, 0);
            btnCalculateValues.Name = "btnCalculateValues";
            btnCalculateValues.Size = new Size(160, 50);
            btnCalculateValues.TabIndex = 5;
            btnCalculateValues.Text = "Calculate Nutritional Values";
            btnCalculateValues.UseVisualStyleBackColor = false;
            btnCalculateValues.Click += btnCalculateValues_Click;
            // 
            // btnIngredients
            // 
            btnIngredients.BackColor = Color.OrangeRed;
            btnIngredients.FlatAppearance.BorderSize = 0;
            btnIngredients.FlatStyle = FlatStyle.Flat;
            btnIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngredients.ForeColor = Color.White;
            btnIngredients.Location = new Point(480, 0);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(160, 50);
            btnIngredients.TabIndex = 4;
            btnIngredients.Text = "Ingredients";
            btnIngredients.UseVisualStyleBackColor = false;
            btnIngredients.Click += btnIngredients_Click_1;
            // 
            // btnRecipes
            // 
            btnRecipes.BackColor = Color.OrangeRed;
            btnRecipes.FlatAppearance.BorderSize = 0;
            btnRecipes.FlatStyle = FlatStyle.Flat;
            btnRecipes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecipes.ForeColor = Color.White;
            btnRecipes.Location = new Point(320, 0);
            btnRecipes.Name = "btnRecipes";
            btnRecipes.Size = new Size(160, 50);
            btnRecipes.TabIndex = 3;
            btnRecipes.Text = "Recipes";
            btnRecipes.UseVisualStyleBackColor = false;
            btnRecipes.Click += btnRecipes_Click;
            // 
            // btnMyRecipes
            // 
            btnMyRecipes.BackColor = Color.White;
            btnMyRecipes.FlatAppearance.BorderSize = 0;
            btnMyRecipes.FlatStyle = FlatStyle.Flat;
            btnMyRecipes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyRecipes.ForeColor = Color.OrangeRed;
            btnMyRecipes.Location = new Point(160, 0);
            btnMyRecipes.Name = "btnMyRecipes";
            btnMyRecipes.Size = new Size(160, 50);
            btnMyRecipes.TabIndex = 2;
            btnMyRecipes.Text = "My Recipes";
            btnMyRecipes.UseVisualStyleBackColor = false;
            btnMyRecipes.Click += btnMyRecipes_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblMealTime);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-11, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1144, 28);
            panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoOrange_01_01;
            pictureBox2.Location = new Point(-68, -19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(236, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblMealTime
            // 
            lblMealTime.AutoSize = true;
            lblMealTime.BackColor = Color.Transparent;
            lblMealTime.ForeColor = Color.OrangeRed;
            lblMealTime.Location = new Point(820, 7);
            lblMealTime.Name = "lblMealTime";
            lblMealTime.Size = new Size(38, 15);
            lblMealTime.TabIndex = 5;
            lblMealTime.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(1059, 7);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(54, 13);
            label1.TabIndex = 3;
            label1.Text = "fitSphere";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(2, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(1131, 535);
            panel3.TabIndex = 29;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(btnViewMyRecipes);
            panel5.Location = new Point(583, 42);
            panel5.Name = "panel5";
            panel5.Size = new Size(511, 440);
            panel5.TabIndex = 2;
            panel5.MouseEnter += panel5_MouseEnter;
            panel5.MouseLeave += panel5_MouseLeave;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.view_01;
            pictureBox3.Location = new Point(3, 78);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(505, 224);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            // 
            // btnViewMyRecipes
            // 
            btnViewMyRecipes.BackColor = Color.Sienna;
            btnViewMyRecipes.FlatAppearance.BorderSize = 0;
            btnViewMyRecipes.FlatStyle = FlatStyle.Flat;
            btnViewMyRecipes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewMyRecipes.ForeColor = Color.White;
            btnViewMyRecipes.Location = new Point(0, 344);
            btnViewMyRecipes.Name = "btnViewMyRecipes";
            btnViewMyRecipes.Size = new Size(511, 95);
            btnViewMyRecipes.TabIndex = 0;
            btnViewMyRecipes.Text = "View My Recipes";
            btnViewMyRecipes.UseVisualStyleBackColor = false;
            btnViewMyRecipes.Click += btnViewMyRecipes_Click_1;
            btnViewMyRecipes.MouseEnter += btnViewMyRecipes_MouseEnter;
            btnViewMyRecipes.MouseLeave += btnViewMyRecipes_MouseLeave;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btnAddNewRecipe);
            panel4.Location = new Point(38, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(511, 440);
            panel4.TabIndex = 1;
            panel4.Click += panel4_Click;
            panel4.MouseEnter += panel4_MouseEnter;
            panel4.MouseLeave += panel4_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add_01;
            pictureBox1.Location = new Point(3, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(505, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // btnAddNewRecipe
            // 
            btnAddNewRecipe.BackColor = Color.OrangeRed;
            btnAddNewRecipe.FlatAppearance.BorderSize = 0;
            btnAddNewRecipe.FlatStyle = FlatStyle.Flat;
            btnAddNewRecipe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewRecipe.ForeColor = Color.White;
            btnAddNewRecipe.Location = new Point(0, 344);
            btnAddNewRecipe.Name = "btnAddNewRecipe";
            btnAddNewRecipe.Size = new Size(511, 95);
            btnAddNewRecipe.TabIndex = 0;
            btnAddNewRecipe.Text = "Add a New Recipe";
            btnAddNewRecipe.UseVisualStyleBackColor = false;
            btnAddNewRecipe.Click += button1_Click;
            btnAddNewRecipe.MouseEnter += btnAddNewRecipe_MouseEnter;
            btnAddNewRecipe.MouseLeave += btnAddNewRecipe_MouseLeave;
            // 
            // MyRecipes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 609);
            Controls.Add(btnHome);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            MaximumSize = new Size(1152, 648);
            Name = "MyRecipes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyRecipes";
            Load += MyRecipes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private Panel panel1;
        private Label lblUser;
        private Button btnCalculateValues;
        private Button btnIngredients;
        private Button btnRecipes;
        private Button btnMyRecipes;
        private Panel panel2;
        private Label lblMealTime;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Button btnAddNewRecipe;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Button btnViewMyRecipes;
    }
}