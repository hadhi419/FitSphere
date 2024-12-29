namespace FitSphere.Forms
{
    partial class confirmEmal
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
            txtOTP = new TextBox();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // txtOTP
            // 
            txtOTP.Location = new Point(141, 123);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(133, 23);
            txtOTP.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(165, 179);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "button1";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // confirmEmal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 381);
            Controls.Add(btnConfirm);
            Controls.Add(txtOTP);
            Name = "confirmEmal";
            Text = "confirmEmal";
            Load += confirmEmal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOTP;
        private Button btnConfirm;
    }
}