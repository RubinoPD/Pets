namespace PETS.UserPages
{
    partial class SupervisorAdministrationPage
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
            this.supervisorDataGridView = new System.Windows.Forms.DataGridView();
            this.supervisorIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editSupervisorButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteSupervisorButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supervisorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supervisorDataGridView
            // 
            this.supervisorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supervisorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supervisorIDColumn,
            this.nameColumn,
            this.surnameColumn,
            this.phoneColumn,
            this.loginIDColumn,
            this.roleIDColumn,
            this.emailColumn,
            this.editSupervisorButtonColumn,
            this.deleteSupervisorButtonColumn});
            this.supervisorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supervisorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.supervisorDataGridView.Name = "supervisorDataGridView";
            this.supervisorDataGridView.RowTemplate.Height = 24;
            this.supervisorDataGridView.Size = new System.Drawing.Size(800, 450);
            this.supervisorDataGridView.TabIndex = 0;
            this.supervisorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supervisorDataGridView_CellContentClick);
            // 
            // supervisorIDColumn
            // 
            this.supervisorIDColumn.HeaderText = "Supervisor ID";
            this.supervisorIDColumn.Name = "supervisorIDColumn";
            this.supervisorIDColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // surnameColumn
            // 
            this.surnameColumn.HeaderText = "Surname";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            // 
            // phoneColumn
            // 
            this.phoneColumn.HeaderText = "Phone Number";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // loginIDColumn
            // 
            this.loginIDColumn.HeaderText = "Login ID";
            this.loginIDColumn.Name = "loginIDColumn";
            this.loginIDColumn.ReadOnly = true;
            // 
            // roleIDColumn
            // 
            this.roleIDColumn.HeaderText = "Role ID";
            this.roleIDColumn.Name = "roleIDColumn";
            this.roleIDColumn.ReadOnly = true;
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            // 
            // editSupervisorButtonColumn
            // 
            this.editSupervisorButtonColumn.HeaderText = "Edit Supervisor";
            this.editSupervisorButtonColumn.Name = "editSupervisorButtonColumn";
            this.editSupervisorButtonColumn.Text = "Edit";
            this.editSupervisorButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteSupervisorButtonColumn
            // 
            this.deleteSupervisorButtonColumn.HeaderText = "Delete Supervisor";
            this.deleteSupervisorButtonColumn.Name = "deleteSupervisorButtonColumn";
            this.deleteSupervisorButtonColumn.Text = "Delete";
            this.deleteSupervisorButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // SupervisorAdministrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.supervisorDataGridView);
            this.Name = "SupervisorAdministrationPage";
            this.Text = "Supervisor Administration";
            ((System.ComponentModel.ISupportInitialize)(this.supervisorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView supervisorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editSupervisorButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteSupervisorButtonColumn;
    }
}
