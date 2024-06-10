namespace PETS.UserPages
{
    partial class ClinicAdministrationPage
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

        
        private void InitializeComponent()
        {
            this.clinicDataGridView = new System.Windows.Forms.DataGridView();
            this.clinicIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicCityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editClinicButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteClinicButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clinicDataGridView
            // 
            this.clinicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clinicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clinicIDColumn,
            this.clinicNameColumn,
            this.clinicAddressColumn,
            this.clinicCityColumn,
            this.editClinicButtonColumn,
            this.deleteClinicButtonColumn});
            this.clinicDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clinicDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clinicDataGridView.Name = "clinicDataGridView";
            this.clinicDataGridView.RowTemplate.Height = 24;
            this.clinicDataGridView.Size = new System.Drawing.Size(800, 450);
            this.clinicDataGridView.TabIndex = 0;
            this.clinicDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clinicDataGridView_CellContentClick);
            // 
            // clinicIDColumn
            // 
            this.clinicIDColumn.HeaderText = "Clinic ID";
            this.clinicIDColumn.Name = "clinicIDColumn";
            this.clinicIDColumn.ReadOnly = true;
            // 
            // clinicNameColumn
            // 
            this.clinicNameColumn.HeaderText = "Clinic Name";
            this.clinicNameColumn.Name = "clinicNameColumn";
            this.clinicNameColumn.ReadOnly = true;
            // 
            // clinicAddressColumn
            // 
            this.clinicAddressColumn.HeaderText = "Address";
            this.clinicAddressColumn.Name = "clinicAddressColumn";
            this.clinicAddressColumn.ReadOnly = true;
            // 
            // clinicCityColumn
            // 
            this.clinicCityColumn.HeaderText = "City";
            this.clinicCityColumn.Name = "clinicCityColumn";
            this.clinicCityColumn.ReadOnly = true;
            // 
            // editClinicButtonColumn
            // 
            this.editClinicButtonColumn.HeaderText = "Edit Clinic";
            this.editClinicButtonColumn.Name = "editClinicButtonColumn";
            this.editClinicButtonColumn.Text = "Edit";
            this.editClinicButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteClinicButtonColumn
            // 
            this.deleteClinicButtonColumn.HeaderText = "Delete Clinic";
            this.deleteClinicButtonColumn.Name = "deleteClinicButtonColumn";
            this.deleteClinicButtonColumn.Text = "Delete";
            this.deleteClinicButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // ClinicAdministrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clinicDataGridView);
            this.Name = "ClinicAdministrationPage";
            this.Text = "Clinic Administration";
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView clinicDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicCityColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editClinicButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteClinicButtonColumn;
    }
}