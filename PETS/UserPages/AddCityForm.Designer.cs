namespace PETS.UserPages
{
    partial class AddCityForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.AutoSize = true;
            this.cityNameLabel.Location = new System.Drawing.Point(12, 15);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(72, 17);
            this.cityNameLabel.TabIndex = 1;
            this.cityNameLabel.Text = "City Name";
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(95, 12);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.cityNameTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(95, 50);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddCityForm
            // 
            this.ClientSize = new System.Drawing.Size(307, 85);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cityNameTextBox);
            this.Controls.Add(this.cityNameLabel);
            this.Name = "AddCityForm";
            this.Text = "Add City";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label cityNameLabel;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.Button addButton;
    }
}
