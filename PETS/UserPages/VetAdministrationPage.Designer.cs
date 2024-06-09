namespace PETS.UserPages
{
    partial class VetAdministrationPage
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
            this.vetDataGridView = new System.Windows.Forms.DataGridView();
            this.vetIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editVetButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteVetButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vetDataGridView
            // 
            this.vetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vetIDColumn,
            this.firstNameColumn,
            this.lastNameColumn,
            this.clinicNameColumn,
            this.editVetButtonColumn,
            this.deleteVetButtonColumn});
            this.vetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetDataGridView.Location = new System.Drawing.Point(0, 0);
            this.vetDataGridView.Name = "vetDataGridView";
            this.vetDataGridView.RowTemplate.Height = 24;
            this.vetDataGridView.Size = new System.Drawing.Size(800, 450);
            this.vetDataGridView.TabIndex = 0;
            this.vetDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vetDataGridView_CellContentClick);
            // 
            // vetIDColumn
            // 
            this.vetIDColumn.HeaderText = "Vet ID";
            this.vetIDColumn.Name = "vetIDColumn";
            this.vetIDColumn.ReadOnly = true;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.HeaderText = "First Name";
            this.firstNameColumn.Name = "firstNameColumn";
            this.firstNameColumn.ReadOnly = true;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.HeaderText = "Last Name";
            this.lastNameColumn.Name = "lastNameColumn";
            this.lastNameColumn.ReadOnly = true;
            // 
            // clinicIDColumn
            // 
            this.clinicNameColumn.HeaderText = "Clinic Name";
            this.clinicNameColumn.Name = "clinicNameColumn";
            this.clinicNameColumn.ReadOnly = true;
            // 
            // editVetButtonColumn
            // 
            this.editVetButtonColumn.HeaderText = "Edit Vet";
            this.editVetButtonColumn.Name = "editVetButtonColumn";
            this.editVetButtonColumn.Text = "Edit";
            this.editVetButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteVetButtonColumn
            // 
            this.deleteVetButtonColumn.HeaderText = "Delete Vet";
            this.deleteVetButtonColumn.Name = "deleteVetButtonColumn";
            this.deleteVetButtonColumn.Text = "Delete";
            this.deleteVetButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // VetAdministrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vetDataGridView);
            this.Name = "VetAdministrationPage";
            this.Text = "Vet Administration";
            ((System.ComponentModel.ISupportInitialize)(this.vetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView vetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editVetButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteVetButtonColumn;
    }
}
