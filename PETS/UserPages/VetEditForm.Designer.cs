namespace PETS.UserPages
{
    partial class VetEditForm
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
            this.vetIdLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.clinicLabel = new System.Windows.Forms.Label();
            this.vetIdTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.clinicComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vetIdLabel
            // 
            this.vetIdLabel.AutoSize = true;
            this.vetIdLabel.Location = new System.Drawing.Point(12, 15);
            this.vetIdLabel.Name = "vetIdLabel";
            this.vetIdLabel.Size = new System.Drawing.Size(47, 17);
            this.vetIdLabel.TabIndex = 0;
            this.vetIdLabel.Text = "Vet ID";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 45);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 75);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // clinicLabel
            // 
            this.clinicLabel.AutoSize = true;
            this.clinicLabel.Location = new System.Drawing.Point(12, 105);
            this.clinicLabel.Name = "clinicLabel";
            this.clinicLabel.Size = new System.Drawing.Size(43, 17);
            this.clinicLabel.TabIndex = 3;
            this.clinicLabel.Text = "Clinic";
            // 
            // vetIdTextBox
            // 
            this.vetIdTextBox.Enabled = false;
            this.vetIdTextBox.Location = new System.Drawing.Point(95, 12);
            this.vetIdTextBox.Name = "vetIdTextBox";
            this.vetIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.vetIdTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(95, 42);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(95, 72);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // clinicComboBox
            // 
            this.clinicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clinicComboBox.FormattingEnabled = true;
            this.clinicComboBox.Location = new System.Drawing.Point(95, 102);
            this.clinicComboBox.Name = "clinicComboBox";
            this.clinicComboBox.Size = new System.Drawing.Size(200, 24);
            this.clinicComboBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(95, 140);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // VetEditForm
            // 
            this.ClientSize = new System.Drawing.Size(307, 175);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clinicComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.vetIdTextBox);
            this.Controls.Add(this.clinicLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.vetIdLabel);
            this.Name = "VetEditForm";
            this.Text = "Edit Vet";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label vetIdLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label clinicLabel;
        private System.Windows.Forms.TextBox vetIdTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox clinicComboBox;
        private System.Windows.Forms.Button saveButton;
    }
}
