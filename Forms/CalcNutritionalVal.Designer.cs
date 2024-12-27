namespace FitSphere.Forms
{
    partial class CalcNutritionalVal
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
            flowLayoutIngredients = new FlowLayoutPanel();
            btnAdd = new Button();
            txtIngredient = new TextBox();
            label14 = new Label();
            txtCarb = new TextBox();
            label13 = new Label();
            txtProtein = new TextBox();
            label12 = new Label();
            txtCholesterol = new TextBox();
            label11 = new Label();
            txtTotalFat = new TextBox();
            label10 = new Label();
            txtFatSaturated = new TextBox();
            label9 = new Label();
            txtPotassium = new TextBox();
            label8 = new Label();
            txtSodium = new TextBox();
            label7 = new Label();
            txtFibre = new TextBox();
            label6 = new Label();
            txtSugar = new TextBox();
            label5 = new Label();
            txtCalories = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            btnHome.TabIndex = 8;
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
            panel1.TabIndex = 9;
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
            btnCalculateValues.BackColor = Color.White;
            btnCalculateValues.FlatAppearance.BorderSize = 0;
            btnCalculateValues.FlatStyle = FlatStyle.Flat;
            btnCalculateValues.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateValues.ForeColor = Color.OrangeRed;
            btnCalculateValues.Location = new Point(640, 0);
            btnCalculateValues.Name = "btnCalculateValues";
            btnCalculateValues.Size = new Size(160, 50);
            btnCalculateValues.TabIndex = 5;
            btnCalculateValues.Text = "Calculate Nutritional Values";
            btnCalculateValues.UseVisualStyleBackColor = false;
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
            btnRecipes.Click += btnRecipes_Click_1;
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
            panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoOrange_01_01;
            pictureBox2.Location = new Point(-66, -20);
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
            lblMealTime.Click += lblMealTime_Click;
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
            // flowLayoutIngredients
            // 
            flowLayoutIngredients.AutoScroll = true;
            flowLayoutIngredients.Location = new Point(12, 138);
            flowLayoutIngredients.Name = "flowLayoutIngredients";
            flowLayoutIngredients.Size = new Size(550, 459);
            flowLayoutIngredients.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.OrangeRed;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(458, 95);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtIngredient
            // 
            txtIngredient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIngredient.ForeColor = Color.OrangeRed;
            txtIngredient.Location = new Point(12, 95);
            txtIngredient.Name = "txtIngredient";
            txtIngredient.PlaceholderText = "100g Onion";
            txtIngredient.Size = new Size(440, 23);
            txtIngredient.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label14.Location = new Point(586, 540);
            label14.Name = "label14";
            label14.Size = new Size(175, 20);
            label14.TabIndex = 58;
            label14.Text = "Total Carbohydrates (g)";
            // 
            // txtCarb
            // 
            txtCarb.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCarb.Location = new Point(788, 541);
            txtCarb.Name = "txtCarb";
            txtCarb.Size = new Size(315, 23);
            txtCarb.TabIndex = 57;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label13.Location = new Point(586, 493);
            label13.Name = "label13";
            label13.Size = new Size(124, 20);
            label13.TabIndex = 56;
            label13.Text = "Total Protein (g)";
            // 
            // txtProtein
            // 
            txtProtein.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtProtein.Location = new Point(788, 494);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(315, 23);
            txtProtein.TabIndex = 55;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label12.Location = new Point(586, 449);
            label12.Name = "label12";
            label12.Size = new Size(166, 20);
            label12.TabIndex = 54;
            label12.Text = "Total Cholesterol (mg)";
            // 
            // txtCholesterol
            // 
            txtCholesterol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCholesterol.Location = new Point(788, 450);
            txtCholesterol.Name = "txtCholesterol";
            txtCholesterol.Size = new Size(315, 23);
            txtCholesterol.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label11.Location = new Point(586, 404);
            label11.Name = "label11";
            label11.Size = new Size(95, 20);
            label11.TabIndex = 52;
            label11.Text = "Total Fat (g)";
            // 
            // txtTotalFat
            // 
            txtTotalFat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTotalFat.Location = new Point(788, 405);
            txtTotalFat.Name = "txtTotalFat";
            txtTotalFat.Size = new Size(315, 23);
            txtTotalFat.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.Location = new Point(586, 359);
            label10.Name = "label10";
            label10.Size = new Size(167, 20);
            label10.TabIndex = 50;
            label10.Text = "Total Fat Saturated (g)";
            // 
            // txtFatSaturated
            // 
            txtFatSaturated.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFatSaturated.Location = new Point(788, 360);
            txtFatSaturated.Name = "txtFatSaturated";
            txtFatSaturated.Size = new Size(315, 23);
            txtFatSaturated.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.Location = new Point(586, 315);
            label9.Name = "label9";
            label9.Size = new Size(160, 20);
            label9.TabIndex = 48;
            label9.Text = "Total Potassium (mg)";
            // 
            // txtPotassium
            // 
            txtPotassium.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPotassium.Location = new Point(788, 316);
            txtPotassium.Name = "txtPotassium";
            txtPotassium.Size = new Size(315, 23);
            txtPotassium.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.Location = new Point(586, 270);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 46;
            label8.Text = "Total Sodium (mg)";
            // 
            // txtSodium
            // 
            txtSodium.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSodium.Location = new Point(788, 271);
            txtSodium.Name = "txtSodium";
            txtSodium.Size = new Size(315, 23);
            txtSodium.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(586, 225);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 44;
            label7.Text = "Total Fibre (g)";
            // 
            // txtFibre
            // 
            txtFibre.AcceptsReturn = true;
            txtFibre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFibre.Location = new Point(788, 226);
            txtFibre.Name = "txtFibre";
            txtFibre.Size = new Size(315, 23);
            txtFibre.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(586, 181);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 42;
            label6.Text = "Total  Sugar (g)";
            // 
            // txtSugar
            // 
            txtSugar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSugar.Location = new Point(788, 182);
            txtSugar.Name = "txtSugar";
            txtSugar.Size = new Size(315, 23);
            txtSugar.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(586, 138);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 40;
            label5.Text = "Total Calories";
            // 
            // txtCalories
            // 
            txtCalories.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCalories.Location = new Point(788, 139);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(315, 23);
            txtCalories.TabIndex = 39;
            // 
            // CalcNutritionalVal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 609);
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
            Controls.Add(btnAdd);
            Controls.Add(txtIngredient);
            Controls.Add(flowLayoutIngredients);
            Controls.Add(btnHome);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximumSize = new Size(1152, 648);
            Name = "CalcNutritionalVal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalcNutritionalVal";
            Load += CalcNutritionalVal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private FlowLayoutPanel flowLayoutIngredients;
        private Button btnAdd;
        private TextBox txtIngredient;
        private Label label14;
        private TextBox txtCarb;
        private Label label13;
        private TextBox txtProtein;
        private Label label12;
        private TextBox txtCholesterol;
        private Label label11;
        private TextBox txtTotalFat;
        private Label label10;
        private TextBox txtFatSaturated;
        private Label label9;
        private TextBox txtPotassium;
        private Label label8;
        private TextBox txtSodium;
        private Label label7;
        private TextBox txtFibre;
        private Label label6;
        private TextBox txtSugar;
        private Label label5;
        private TextBox txtCalories;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}