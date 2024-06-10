namespace PETS.UserPages
{
    partial class ClinicEditForm
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
            this.clinicIdLabel = new System.Windows.Forms.Label();
            this.clinicNameLabel = new System.Windows.Forms.Label();
            this.clinicAddressLabel = new System.Windows.Forms.Label();
            this.clinicCityLabel = new System.Windows.Forms.Label();
            this.clinicIdTextBox = new System.Windows.Forms.TextBox();
            this.clinicNameTextBox = new System.Windows.Forms.TextBox();
            this.clinicAddressTextBox = new System.Windows.Forms.TextBox();
            this.clinicCityComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clinicIdLabel
            // 
            this.clinicIdLabel.AutoSize = true;
            this.clinicIdLabel.Location = new System.Drawing.Point(12, 15);
            this.clinicIdLabel.Name = "clinicIdLabel";
            this.clinicIdLabel.Size = new System.Drawing.Size(62, 17);
            this.clinicIdLabel.TabIndex = 0;
            this.clinicIdLabel.Text = "Clinic ID";
            // 
            // clinicNameLabel
            // 
            this.clinicNameLabel.AutoSize = true;
            this.clinicNameLabel.Location = new System.Drawing.Point(12, 45);
            this.clinicNameLabel.Name = "clinicNameLabel";
            this.clinicNameLabel.Size = new System.Drawing.Size(83, 17);
            this.clinicNameLabel.TabIndex = 1;
            this.clinicNameLabel.Text = "Clinic Name";
            // 
            // clinicAddressLabel
            // 
            this.clinicAddressLabel.AutoSize = true;
            this.clinicAddressLabel.Location = new System.Drawing.Point(12, 75);
            this.clinicAddressLabel.Name = "clinicAddressLabel";
            this.clinicAddressLabel.Size = new System.Drawing.Size(60, 17);
            this.clinicAddressLabel.TabIndex = 2;
            this.clinicAddressLabel.Text = "Address";
            // 
            // clinicCityLabel
            // 
            this.clinicCityLabel.AutoSize = true;
            this.clinicCityLabel.Location = new System.Drawing.Point(12, 105);
            this.clinicCityLabel.Name = "clinicCityLabel";
            this.clinicCityLabel.Size = new System.Drawing.Size(31, 17);
            this.clinicCityLabel.TabIndex = 3;
            this.clinicCityLabel.Text = "City";
            // 
            // clinicIdTextBox
            // 
            this.clinicIdTextBox.Enabled = false;
            this.clinicIdTextBox.Location = new System.Drawing.Point(101, 12);
            this.clinicIdTextBox.Name = "clinicIdTextBox";
            this.clinicIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.clinicIdTextBox.TabIndex = 6;
            // 
            // clinicNameTextBox
            // 
            this.clinicNameTextBox.Location = new System.Drawing.Point(101, 42);
            this.clinicNameTextBox.Name = "clinicNameTextBox";
            this.clinicNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.clinicNameTextBox.TabIndex = 7;
            // 
            // clinicAddressTextBox
            // 
            this.clinicAddressTextBox.Location = new System.Drawing.Point(101, 72);
            this.clinicAddressTextBox.Name = "clinicAddressTextBox";
            this.clinicAddressTextBox.Size = new System.Drawing.Size(200, 22);
            this.clinicAddressTextBox.TabIndex = 8;
            // 
            // clinicCityComboBox
            // 
            this.clinicCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clinicCityComboBox.FormattingEnabled = true;
            this.clinicCityComboBox.Location = new System.Drawing.Point(101, 102);
            this.clinicCityComboBox.Name = "clinicCityComboBox";
            this.clinicCityComboBox.Size = new System.Drawing.Size(200, 24);
            this.clinicCityComboBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(101, 140);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ClinicEditForm
            // 
            this.ClientSize = new System.Drawing.Size(307, 175);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clinicCityComboBox);
            this.Controls.Add(this.clinicAddressTextBox);
            this.Controls.Add(this.clinicNameTextBox);
            this.Controls.Add(this.clinicIdTextBox);
            this.Controls.Add(this.clinicCityLabel);
            this.Controls.Add(this.clinicAddressLabel);
            this.Controls.Add(this.clinicNameLabel);
            this.Controls.Add(this.clinicIdLabel);
            this.Name = "ClinicEditForm";
            this.Text = "Edit Clinic";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label clinicIdLabel;
        private System.Windows.Forms.Label clinicNameLabel;
        private System.Windows.Forms.Label clinicAddressLabel;
        private System.Windows.Forms.Label clinicCityLabel;
        private System.Windows.Forms.TextBox clinicIdTextBox;
        private System.Windows.Forms.TextBox clinicNameTextBox;
        private System.Windows.Forms.TextBox clinicAddressTextBox;
        private System.Windows.Forms.ComboBox clinicCityComboBox;
        private System.Windows.Forms.Button saveButton;
    }
}
