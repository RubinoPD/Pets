namespace PETS.UserPages
{
    partial class AddClinicForm
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
            this.clinicNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.clinicNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clinicNameLabel
            // 
            this.clinicNameLabel.AutoSize = true;
            this.clinicNameLabel.Location = new System.Drawing.Point(12, 15);
            this.clinicNameLabel.Name = "clinicNameLabel";
            this.clinicNameLabel.Size = new System.Drawing.Size(83, 17);
            this.clinicNameLabel.TabIndex = 1;
            this.clinicNameLabel.Text = "Clinic Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 45);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 75);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City";
            // 
            // clinicNameTextBox
            // 
            this.clinicNameTextBox.Location = new System.Drawing.Point(101, 12);
            this.clinicNameTextBox.Name = "clinicNameTextBox";
            this.clinicNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.clinicNameTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(101, 42);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 22);
            this.addressTextBox.TabIndex = 8;
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(101, 72);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(200, 24);
            this.cityComboBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(101, 110);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddClinicForm
            // 
            this.ClientSize = new System.Drawing.Size(307, 145);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.clinicNameTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.clinicNameLabel);
            this.Name = "AddClinicForm";
            this.Text = "Add Clinic";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label clinicNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox clinicNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Button addButton;
    }
}
