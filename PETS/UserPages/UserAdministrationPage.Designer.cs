namespace PETS.UserPages
{
    partial class UserAdministrationPage
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
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.userIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editUserButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteUserButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDColumn,
            this.firstNameColumn,
            this.lastNameColumn,
            this.emailColumn,
            this.addressColumn,
            this.petsNameColumn,
            this.editUserButtonColumn,
            this.deleteUserButtonColumn});
            this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataGridView.Location = new System.Drawing.Point(0, 0);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowTemplate.Height = 24;
            this.userDataGridView.Size = new System.Drawing.Size(800, 450);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // userIDColumn
            // 
            this.userIDColumn.HeaderText = "User ID";
            this.userIDColumn.Name = "userIDColumn";
            this.userIDColumn.ReadOnly = true;
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
            // emailColumn
            // 
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            // 
            // addressColumn
            // 
            this.addressColumn.HeaderText = "Address";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            // 
            // petsNameColumn
            // 
            this.petsNameColumn.HeaderText = "Pet's Name";
            this.petsNameColumn.Name = "petsNameColumn";
            this.petsNameColumn.ReadOnly = true;
            // 
            // editUserButtonColumn
            // 
            this.editUserButtonColumn.HeaderText = "Edit User";
            this.editUserButtonColumn.Name = "editUserButtonColumn";
            this.editUserButtonColumn.Text = "Edit";
            this.editUserButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteUserButtonColumn
            // 
            this.deleteUserButtonColumn.HeaderText = "Delete User";
            this.deleteUserButtonColumn.Name = "deleteUserButtonColumn";
            this.deleteUserButtonColumn.Text = "Delete";
            this.deleteUserButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // UserAdministrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userDataGridView);
            this.Name = "UserAdministrationPage";
            this.Text = "User Administration";
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petsNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editUserButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteUserButtonColumn;
    }
}
