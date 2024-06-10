namespace PETS.UserPages
{
    partial class SupervisorEditForm
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
            this.supervisorIdLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.supervisorIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // supervisorIdLabel
            // 
            this.supervisorIdLabel.AutoSize = true;
            this.supervisorIdLabel.Location = new System.Drawing.Point(12, 15);
            this.supervisorIdLabel.Name = "supervisorIdLabel";
            this.supervisorIdLabel.Size = new System.Drawing.Size(91, 17);
            this.supervisorIdLabel.TabIndex = 0;
            this.supervisorIdLabel.Text = "Supervisor ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 75);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(65, 17);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 105);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone Number";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 135);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            // 
            // supervisorIdTextBox
            // 
            this.supervisorIdTextBox.Enabled = false;
            this.supervisorIdTextBox.Location = new System.Drawing.Point(120, 12);
            this.supervisorIdTextBox.Name = "supervisorIdTextBox";
            this.supervisorIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.supervisorIdTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(120, 42);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(120, 72);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.surnameTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(120, 102);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.phoneTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(120, 132);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(120, 160);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SupervisorEditForm
            // 
            this.ClientSize = new System.Drawing.Size(332, 195);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.supervisorIdTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.supervisorIdLabel);
            this.Name = "SupervisorEditForm";
            this.Text = "Edit Supervisor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label supervisorIdLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox supervisorIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}
