namespace FitSphere.Forms
{
    partial class AddMyRecipeDetails
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
            txtDirections = new TextBox();
            label4 = new Label();
            txtIngredients = new TextBox();
            label6 = new Label();
            txtDescription = new TextBox();
            lblRecipeName = new Label();
            panel3 = new Panel();
            btnAdd = new Button();
            label1 = new Label();
            txtRecipeName = new TextBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtDirections
            // 
            txtDirections.BackColor = Color.PeachPuff;
            txtDirections.BorderStyle = BorderStyle.None;
            txtDirections.ForeColor = Color.Black;
            txtDirections.Location = new Point(608, 231);
            txtDirections.Multiline = true;
            txtDirections.Name = "txtDirections";
            txtDirections.ScrollBars = ScrollBars.Both;
            txtDirections.Size = new Size(496, 207);
            txtDirections.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(608, 202);
            label4.Name = "label4";
            label4.Size = new Size(251, 22);
            label4.TabIndex = 34;
            label4.Text = "Directions to be Followed: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIngredients
            // 
            txtIngredients.BackColor = Color.PeachPuff;
            txtIngredients.BorderStyle = BorderStyle.None;
            txtIngredients.ForeColor = Color.Black;
            txtIngredients.Location = new Point(31, 232);
            txtIngredients.Multiline = true;
            txtIngredients.Name = "txtIngredients";
            txtIngredients.ScrollBars = ScrollBars.Both;
            txtIngredients.Size = new Size(450, 207);
            txtIngredients.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(27, 203);
            label6.Name = "label6";
            label6.Size = new Size(201, 22);
            label6.TabIndex = 31;
            label6.Text = "Ingredients Needed: ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.PeachPuff;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.ForeColor = SystemColors.ActiveCaptionText;
            txtDescription.Location = new Point(174, 89);
            txtDescription.MaxLength = 300;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(930, 63);
            txtDescription.TabIndex = 32;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = Color.White;
            lblRecipeName.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipeName.ForeColor = SystemColors.ActiveCaptionText;
            lblRecipeName.Location = new Point(24, 46);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(144, 24);
            lblRecipeName.TabIndex = 30;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(txtDirections);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtRecipeName);
            panel3.Controls.Add(lblRecipeName);
            panel3.Controls.Add(txtDescription);
            panel3.Location = new Point(3, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1131, 571);
            panel3.TabIndex = 36;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.OrangeRed;
            btnAdd.FlatAppearance.BorderColor = Color.OrangeRed;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Snow;
            btnAdd.Location = new Point(934, 478);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 33);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add to my Recipes";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(24, 98);
            label1.Name = "label1";
            label1.Size = new Size(115, 22);
            label1.TabIndex = 38;
            label1.Text = "Description";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            txtRecipeName.BackColor = Color.PeachPuff;
            txtRecipeName.BorderStyle = BorderStyle.None;
            txtRecipeName.ForeColor = SystemColors.ActiveCaptionText;
            txtRecipeName.Location = new Point(174, 46);
            txtRecipeName.MaxLength = 100;
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(930, 24);
            txtRecipeName.TabIndex = 37;
            // 
            // AddMyRecipeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 609);
            Controls.Add(txtIngredients);
            Controls.Add(label6);
            Controls.Add(panel3);
            Name = "AddMyRecipeDetails";
            Text = "AddMyRecipeDetails";
            Load += AddMyRecipeDetails_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDirections;
        public Label label4;
        private TextBox txtIngredients;
        public Label label6;
        public TextBox txtDescription;
        public Label lblRecipeName;
        private Panel panel3;
        public Label label1;
        public TextBox txtRecipeName;
        public Button btnAdd;
    }
}