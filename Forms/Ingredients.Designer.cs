namespace FitSphere.Forms
{
    partial class Ingredients
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
            btnSearch = new Button();
            txtIngredient = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblMealTime = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRecipes = new Button();
            lblUser = new Label();
            btnCalculateValues = new Button();
            btnIngredients = new Button();
            panel1 = new Panel();
            button2 = new Button();
            btnMyRecipes = new Button();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            txtQuantity = new TextBox();
            txtCalories = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtSugar = new TextBox();
            label7 = new Label();
            txtFibre = new TextBox();
            label8 = new Label();
            txtSodium = new TextBox();
            label9 = new Label();
            txtPotassium = new TextBox();
            label10 = new Label();
            txtFatSaturated = new TextBox();
            label11 = new Label();
            txtTotalFat = new TextBox();
            label12 = new Label();
            txtCholesterol = new TextBox();
            label13 = new Label();
            txtProtein = new TextBox();
            label14 = new Label();
            txtCarb = new TextBox();
            pctrIngredient = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctrIngredient).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Tomato;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1017, 89);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 52);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtIngredient
            // 
            txtIngredient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIngredient.ForeColor = Color.OrangeRed;
            txtIngredient.Location = new Point(108, 90);
            txtIngredient.Name = "txtIngredient";
            txtIngredient.Size = new Size(903, 23);
            txtIngredient.TabIndex = 13;
            txtIngredient.TextChanged += txtSearch_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Ivory;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblMealTime);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-11, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1155, 28);
            panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoOrange_01_01;
            pictureBox1.Location = new Point(-66, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(54, 13);
            label1.TabIndex = 3;
            label1.Text = "fitSphere";
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
            btnRecipes.Click += btnRecipes_Click_1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.PaleTurquoise;
            lblUser.Location = new Point(1015, 19);
            lblUser.Margin = new Padding(3);
            lblUser.MaximumSize = new Size(140, 15);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 2;
            lblUser.Text = "lblUser";
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
            // 
            // btnIngredients
            // 
            btnIngredients.BackColor = Color.Snow;
            btnIngredients.FlatAppearance.BorderSize = 0;
            btnIngredients.FlatStyle = FlatStyle.Flat;
            btnIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngredients.ForeColor = Color.OrangeRed;
            btnIngredients.Location = new Point(480, 0);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(160, 50);
            btnIngredients.TabIndex = 4;
            btnIngredients.Text = "Ingredients";
            btnIngredients.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(btnCalculateValues);
            panel1.Controls.Add(btnIngredients);
            panel1.Controls.Add(btnRecipes);
            panel1.Controls.Add(btnMyRecipes);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(-5, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 50);
            panel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(4, 0);
            button2.Name = "button2";
            button2.Size = new Size(160, 50);
            button2.TabIndex = 6;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnMyRecipes
            // 
            btnMyRecipes.BackColor = Color.OrangeRed;
            btnMyRecipes.FlatAppearance.BorderSize = 0;
            btnMyRecipes.FlatStyle = FlatStyle.Flat;
            btnMyRecipes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyRecipes.ForeColor = Color.White;
            btnMyRecipes.Location = new Point(160, 0);
            btnMyRecipes.Name = "btnMyRecipes";
            btnMyRecipes.Size = new Size(160, 50);
            btnMyRecipes.TabIndex = 2;
            btnMyRecipes.Text = "My Recipes";
            btnMyRecipes.UseVisualStyleBackColor = false;
            btnMyRecipes.Click += btnMyRecipes_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-5, 33);
            button1.Name = "button1";
            button1.Size = new Size(160, 50);
            button1.TabIndex = 10;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PeachPuff;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 15;
            label3.Text = "Ingredient";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PeachPuff;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 17;
            label4.Text = "Quantity   ";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantity.ForeColor = Color.OrangeRed;
            txtQuantity.Location = new Point(108, 119);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Ex -: 100g";
            txtQuantity.Size = new Size(903, 23);
            txtQuantity.TabIndex = 16;
            // 
            // txtCalories
            // 
            txtCalories.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCalories.Location = new Point(231, 165);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(315, 23);
            txtCalories.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 164);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 20;
            label5.Text = "Calories";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(29, 207);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 22;
            label6.Text = "Sugar (g)";
            // 
            // txtSugar
            // 
            txtSugar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSugar.Location = new Point(231, 208);
            txtSugar.Name = "txtSugar";
            txtSugar.Size = new Size(315, 23);
            txtSugar.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(29, 251);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 24;
            label7.Text = "Fibre (g)";
            // 
            // txtFibre
            // 
            txtFibre.AcceptsReturn = true;
            txtFibre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFibre.Location = new Point(231, 252);
            txtFibre.Name = "txtFibre";
            txtFibre.Size = new Size(315, 23);
            txtFibre.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.Location = new Point(29, 296);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 26;
            label8.Text = "Sodium (mg)";
            // 
            // txtSodium
            // 
            txtSodium.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSodium.Location = new Point(231, 297);
            txtSodium.Name = "txtSodium";
            txtSodium.Size = new Size(315, 23);
            txtSodium.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.Location = new Point(29, 341);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 28;
            label9.Text = "Potassium (mg)";
            // 
            // txtPotassium
            // 
            txtPotassium.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPotassium.Location = new Point(231, 342);
            txtPotassium.Name = "txtPotassium";
            txtPotassium.Size = new Size(315, 23);
            txtPotassium.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.Location = new Point(29, 385);
            label10.Name = "label10";
            label10.Size = new Size(128, 20);
            label10.TabIndex = 30;
            label10.Text = "Fat Saturated (g)";
            // 
            // txtFatSaturated
            // 
            txtFatSaturated.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFatSaturated.Location = new Point(231, 386);
            txtFatSaturated.Name = "txtFatSaturated";
            txtFatSaturated.Size = new Size(315, 23);
            txtFatSaturated.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label11.Location = new Point(29, 430);
            label11.Name = "label11";
            label11.Size = new Size(95, 20);
            label11.TabIndex = 32;
            label11.Text = "Total Fat (g)";
            // 
            // txtTotalFat
            // 
            txtTotalFat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTotalFat.Location = new Point(231, 431);
            txtTotalFat.Name = "txtTotalFat";
            txtTotalFat.Size = new Size(315, 23);
            txtTotalFat.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label12.Location = new Point(29, 475);
            label12.Name = "label12";
            label12.Size = new Size(127, 20);
            label12.TabIndex = 34;
            label12.Text = "Cholesterol (mg)";
            // 
            // txtCholesterol
            // 
            txtCholesterol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCholesterol.Location = new Point(231, 476);
            txtCholesterol.Name = "txtCholesterol";
            txtCholesterol.Size = new Size(315, 23);
            txtCholesterol.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label13.Location = new Point(29, 519);
            label13.Name = "label13";
            label13.Size = new Size(85, 20);
            label13.TabIndex = 36;
            label13.Text = "Protein (g)";
            // 
            // txtProtein
            // 
            txtProtein.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtProtein.Location = new Point(231, 520);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(315, 23);
            txtProtein.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label14.Location = new Point(29, 566);
            label14.Name = "label14";
            label14.Size = new Size(175, 20);
            label14.TabIndex = 38;
            label14.Text = "Total Carbohydrates (g)";
            // 
            // txtCarb
            // 
            txtCarb.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCarb.Location = new Point(231, 567);
            txtCarb.Name = "txtCarb";
            txtCarb.Size = new Size(315, 23);
            txtCarb.TabIndex = 37;
            // 
            // pctrIngredient
            // 
            pctrIngredient.Image = Properties.Resources.logoOrange_01_022;
            pctrIngredient.Location = new Point(648, 196);
            pctrIngredient.Name = "pctrIngredient";
            pctrIngredient.Size = new Size(381, 343);
            pctrIngredient.SizeMode = PictureBoxSizeMode.Zoom;
            pctrIngredient.TabIndex = 39;
            pctrIngredient.TabStop = false;
            // 
            // Ingredients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 609);
            Controls.Add(pctrIngredient);
            Controls.Add(label14);
            Controls.Add(txtCarb);
            Controls.Add(label13);
            Controls.Add(txtProtein);
            Controls.Add(label12);
            Controls.Add(txtCholesterol);
            Controls.Add(label11);
            Controls.Add(txtTotalFat);
            Controls.Add(label10);
            Controls.Add(txtFatSaturated);
            Controls.Add(label9);
            Controls.Add(txtPotassium);
            Controls.Add(label8);
            Controls.Add(txtSodium);
            Controls.Add(label7);
            Controls.Add(txtFibre);
            Controls.Add(label6);
            Controls.Add(txtSugar);
            Controls.Add(label5);
            Controls.Add(txtCalories);
            Controls.Add(label4);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(txtIngredient);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Ingredients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingredients";
            Load += Ingredients_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctrIngredient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtIngredient;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
        private Label lblMealTime;
        private Label label2;
        private Label label1;
        private Button btnRecipes;
        private Label lblUser;
        private Button btnCalculateValues;
        private Button btnIngredients;
        private Panel panel1;
        private Button btnMyRecipes;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox txtQuantity;
        private TextBox txtCalories;
        private Label label5;
        private Label label6;
        private TextBox txtSugar;
        private Label label7;
        private TextBox txtFibre;
        private Label label8;
        private TextBox txtSodium;
        private Label label9;
        private TextBox txtPotassium;
        private Label label10;
        private TextBox txtFatSaturated;
        private Label label11;
        private TextBox txtTotalFat;
        private Label label12;
        private TextBox txtCholesterol;
        private Label label13;
        private TextBox txtProtein;
        private Label label14;
        private TextBox txtCarb;
        private PictureBox pctrIngredient;
        private PictureBox pictureBox1;
    }
}