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
            this.userAdministration.Location = new System.Drawing.Point(281, 126);
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
            this.button1.Location = new System.Drawing.Point(286, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Administruoti veterinarus";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clinicAdministration
            // 
            this.clinicAdministration.AccessibleName = "clinicAdministration";
            this.clinicAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicAdministration.Location = new System.Drawing.Point(286, 273);
            this.clinicAdministration.Name = "clinicAdministration";
            this.clinicAdministration.Size = new System.Drawing.Size(228, 47);
            this.clinicAdministration.TabIndex = 4;
            this.clinicAdministration.Text = "Administruoti klinikas";
            this.clinicAdministration.UseVisualStyleBackColor = true;
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
            // supervisorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}