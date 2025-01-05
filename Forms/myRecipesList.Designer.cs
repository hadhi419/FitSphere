namespace FitSphere.Forms
{
    partial class myRecipesList
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
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutRecipes = new FlowLayoutPanel();
            btnAllRecipes = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 59);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(515, 10);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 0;
            label1.Text = "My Recipes";
            // 
            // flowLayoutRecipes
            // 
            flowLayoutRecipes.Location = new Point(12, 136);
            flowLayoutRecipes.Name = "flowLayoutRecipes";
            flowLayoutRecipes.Size = new Size(1112, 461);
            flowLayoutRecipes.TabIndex = 1;
            // 
            // btnAllRecipes
            // 
            btnAllRecipes.BackColor = Color.Green;
            btnAllRecipes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAllRecipes.ForeColor = Color.White;
            btnAllRecipes.Location = new Point(894, 65);
            btnAllRecipes.Name = "btnAllRecipes";
            btnAllRecipes.Size = new Size(208, 44);
            btnAllRecipes.TabIndex = 2;
            btnAllRecipes.Text = "All Recipes";
            btnAllRecipes.UseVisualStyleBackColor = false;
            btnAllRecipes.Click += btnAllRecipes_Click;
            // 
            // myRecipesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 609);
            Controls.Add(btnAllRecipes);
            Controls.Add(flowLayoutRecipes);
            Controls.Add(panel1);
            Name = "myRecipesList";
            Text = "myRecipesList";
            Load += myRecipesList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutRecipes;
        private Button btnAllRecipes;
    }
}