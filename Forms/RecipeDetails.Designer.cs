﻿namespace FitSphere.Forms
{
    partial class RecipeDetails
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
            txtDescription = new TextBox();
            lblRecipeName = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            btnChangePortion = new Button();
            label3 = new Label();
            nmrcPortion = new NumericUpDown();
            txtNutrition = new TextBox();
            label2 = new Label();
            txtIngredients = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcPortion).BeginInit();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.ForeColor = SystemColors.ActiveCaptionText;
            txtDescription.Location = new Point(12, 35);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(563, 68);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "Recipe: Chicken Vegetable Stir-Fry\n\nDescription: Great for the whole family. Use any veggies you have.\n\n";
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = Color.White;
            lblRecipeName.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipeName.ForeColor = Color.OrangeRed;
            lblRecipeName.Location = new Point(8, 10);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(172, 24);
            lblRecipeName.TabIndex = 1;
            lblRecipeName.Text = "Pepper Chicken";
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            lblRecipeName.Click += lblRecipeName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(14, 182);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 3;
            label1.Text = "Ingredients : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnChangePortion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nmrcPortion);
            panel1.Controls.Add(txtNutrition);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtIngredients);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(lblRecipeName);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 629);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.FlatAppearance.BorderColor = Color.OrangeRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(427, 564);
            button2.Name = "button2";
            button2.Size = new Size(113, 33);
            button2.TabIndex = 1;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnChangePortion
            // 
            btnChangePortion.BackColor = Color.OrangeRed;
            btnChangePortion.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btnChangePortion.FlatStyle = FlatStyle.Flat;
            btnChangePortion.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePortion.ForeColor = Color.Snow;
            btnChangePortion.Location = new Point(296, 125);
            btnChangePortion.Name = "btnChangePortion";
            btnChangePortion.Size = new Size(75, 23);
            btnChangePortion.TabIndex = 0;
            btnChangePortion.Text = "Change";
            btnChangePortion.UseVisualStyleBackColor = false;
            btnChangePortion.Click += btnChangePortion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 127);
            label3.Name = "label3";
            label3.Size = new Size(131, 17);
            label3.TabIndex = 8;
            label3.Text = "Number of Portions";
            // 
            // nmrcPortion
            // 
            nmrcPortion.BackColor = Color.White;
            nmrcPortion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmrcPortion.ForeColor = SystemColors.ActiveCaptionText;
            nmrcPortion.Location = new Point(153, 125);
            nmrcPortion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrcPortion.Name = "nmrcPortion";
            nmrcPortion.Size = new Size(120, 23);
            nmrcPortion.TabIndex = 7;
            nmrcPortion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtNutrition
            // 
            txtNutrition.BackColor = Color.PeachPuff;
            txtNutrition.BorderStyle = BorderStyle.None;
            txtNutrition.ForeColor = Color.Black;
            txtNutrition.Location = new Point(13, 408);
            txtNutrition.Multiline = true;
            txtNutrition.Name = "txtNutrition";
            txtNutrition.ScrollBars = ScrollBars.Both;
            txtNutrition.Size = new Size(546, 137);
            txtNutrition.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(13, 374);
            label2.Name = "label2";
            label2.Size = new Size(187, 22);
            label2.TabIndex = 5;
            label2.Text = "Nutritional Values : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIngredients
            // 
            txtIngredients.BackColor = Color.PeachPuff;
            txtIngredients.BorderStyle = BorderStyle.None;
            txtIngredients.ForeColor = Color.Black;
            txtIngredients.Location = new Point(14, 216);
            txtIngredients.Multiline = true;
            txtIngredients.Name = "txtIngredients";
            txtIngredients.ScrollBars = ScrollBars.Both;
            txtIngredients.Size = new Size(545, 137);
            txtIngredients.TabIndex = 20;
            // 
            // RecipeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 609);
            Controls.Add(panel1);
            Name = "RecipeDetails";
            Text = "RecipeDetails";
            Load += RecipeDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcPortion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public TextBox txtDescription;
        public Label lblRecipeName;
        public Label label1;
        private Panel panel1;
        private TextBox txtIngredients;
        private TextBox txtNutrition;
        public Label label2;
        private Label label3;
        private NumericUpDown nmrcPortion;
        private Button btnChangePortion;
        public Button button2;
    }
}