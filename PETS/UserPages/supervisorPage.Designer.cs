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
            this.notificationLabel = new System.Windows.Forms.Label();
            this.userAdministration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clinicAdministration = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.addVetBtn = new System.Windows.Forms.Button();
            this.addClinicBtn = new System.Windows.Forms.Button();
            this.addCityBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // supervisorLabel
            // 
            this.supervisorLabel.AccessibleName = "supervisorLabel";
            this.supervisorLabel.AutoSize = true;
            this.supervisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisorLabel.Location = new System.Drawing.Point(245, 59);
            this.supervisorLabel.Name = "supervisorLabel";
            this.supervisorLabel.Size = new System.Drawing.Size(128, 20);
            this.supervisorLabel.TabIndex = 0;
            this.supervisorLabel.Text = "supervisorLabel";
            this.supervisorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notificationLabel
            // 
            this.notificationLabel.AccessibleName = "notificationLabel";
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationLabel.Location = new System.Drawing.Point(244, 9);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(316, 25);
            this.notificationLabel.TabIndex = 1;
            this.notificationLabel.Text = "Jusu paskyra turi padidintas teises!";
            // 
            // userAdministration
            // 
            this.userAdministration.AccessibleName = "userAdministration";
            this.userAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAdministration.Location = new System.Drawing.Point(145, 122);
            this.userAdministration.Name = "userAdministration";
            this.userAdministration.Size = new System.Drawing.Size(228, 47);
            this.userAdministration.TabIndex = 2;
            this.userAdministration.Text = "Administruoti naudotojus";
            this.userAdministration.UseVisualStyleBackColor = true;
            this.userAdministration.Click += new System.EventHandler(this.userAdministration_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "vetAdministration";
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Administruoti veterinarus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clinicAdministration
            // 
            this.clinicAdministration.AccessibleName = "clinicAdministration";
            this.clinicAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicAdministration.Location = new System.Drawing.Point(145, 228);
            this.clinicAdministration.Name = "clinicAdministration";
            this.clinicAdministration.Size = new System.Drawing.Size(228, 47);
            this.clinicAdministration.TabIndex = 4;
            this.clinicAdministration.Text = "Administruoti klinikas";
            this.clinicAdministration.UseVisualStyleBackColor = true;
            this.clinicAdministration.Click += new System.EventHandler(this.clinicAdministration_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.AccessibleName = "logoutBtn";
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(601, 13);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(171, 30);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Atsijungti";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // addVetBtn
            // 
            this.addVetBtn.AccessibleName = "addVetBtn";
            this.addVetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVetBtn.Location = new System.Drawing.Point(426, 122);
            this.addVetBtn.Name = "addVetBtn";
            this.addVetBtn.Size = new System.Drawing.Size(228, 47);
            this.addVetBtn.TabIndex = 6;
            this.addVetBtn.Text = "Prideti veterinara";
            this.addVetBtn.UseVisualStyleBackColor = true;
            // 
            // addClinicBtn
            // 
            this.addClinicBtn.AccessibleName = "addClinicBtn";
            this.addClinicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClinicBtn.Location = new System.Drawing.Point(426, 175);
            this.addClinicBtn.Name = "addClinicBtn";
            this.addClinicBtn.Size = new System.Drawing.Size(228, 47);
            this.addClinicBtn.TabIndex = 7;
            this.addClinicBtn.Text = "Prideti klinika";
            this.addClinicBtn.UseVisualStyleBackColor = true;
            // 
            // addCityBtn
            // 
            this.addCityBtn.AccessibleName = "addCityBtn";
            this.addCityBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCityBtn.Location = new System.Drawing.Point(426, 228);
            this.addCityBtn.Name = "addCityBtn";
            this.addCityBtn.Size = new System.Drawing.Size(228, 47);
            this.addCityBtn.TabIndex = 8;
            this.addCityBtn.Text = "Prideti miesta";
            this.addCityBtn.UseVisualStyleBackColor = true;
            // 
            // supervisorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCityBtn);
            this.Controls.Add(this.addClinicBtn);
            this.Controls.Add(this.addVetBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.clinicAdministration);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userAdministration);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.supervisorLabel);
            this.Name = "supervisorPage";
            this.Text = "supervisorPage";
            this.Load += new System.EventHandler(this.supervisorPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label supervisorLabel;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Button userAdministration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clinicAdministration;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button addVetBtn;
        private System.Windows.Forms.Button addClinicBtn;
        private System.Windows.Forms.Button addCityBtn;
    }
}