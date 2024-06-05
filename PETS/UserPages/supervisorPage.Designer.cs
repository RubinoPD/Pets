namespace PETS.UserPages
{
    partial class supervisorPage
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
            this.supervisorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supervisorLabel
            // 
            this.supervisorLabel.AccessibleName = "supervisorLabel";
            this.supervisorLabel.AutoSize = true;
            this.supervisorLabel.Location = new System.Drawing.Point(376, 160);
            this.supervisorLabel.Name = "supervisorLabel";
            this.supervisorLabel.Size = new System.Drawing.Size(104, 16);
            this.supervisorLabel.TabIndex = 0;
            this.supervisorLabel.Text = "supervisorLabel";
            // 
            // supervisorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.supervisorLabel);
            this.Name = "supervisorPage";
            this.Text = "supervisorPage";
            this.Load += new System.EventHandler(this.supervisorPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label supervisorLabel;
    }
}