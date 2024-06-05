namespace PETS.UserPages
{
    partial class userPage
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
            this.userLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AccessibleName = "userLabel";
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(316, 188);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(67, 16);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "userLabel";
            // 
            // userPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userLabel);
            this.Name = "userPage";
            this.Text = "userPage";
            this.Load += new System.EventHandler(this.userPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
    }
}