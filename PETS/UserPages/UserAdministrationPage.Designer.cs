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
            this.userListView = new System.Windows.Forms.ListView();
            this.userIDHeader = new System.Windows.Forms.ColumnHeader();
            this.firstNameHeader = new System.Windows.Forms.ColumnHeader();
            this.lastNameHeader = new System.Windows.Forms.ColumnHeader();
            this.emailHeader = new System.Windows.Forms.ColumnHeader();
            this.addressHeader = new System.Windows.Forms.ColumnHeader();
            this.petsHeader = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userIDHeader,
            this.firstNameHeader,
            this.lastNameHeader,
            this.emailHeader,
            this.addressHeader,
            this.petsHeader});
            this.userListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userListView.FullRowSelect = true;
            this.userListView.GridLines = true;
            this.userListView.HideSelection = false;
            this.userListView.Location = new System.Drawing.Point(0, 0);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(800, 450);
            this.userListView.TabIndex = 0;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            // 
            // userIDHeader
            // 
            this.userIDHeader.Text = "User ID";
            // 
            // firstNameHeader
            // 
            this.firstNameHeader.Text = "First Name";
            // 
            // lastNameHeader
            // 
            this.lastNameHeader.Text = "Last Name";
            // 
            // emailHeader
            // 
            this.emailHeader.Text = "Email";
            // 
            // addressHeader
            // 
            this.addressHeader.Text = "Address";
            // 
            // petHeader
            // 
            this.petsHeader.Text = "Pets";
            // 
            // UserAdministrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userListView);
            this.Name = "UserAdministrationPage";
            this.Text = "User Administration";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ColumnHeader userIDHeader;
        private System.Windows.Forms.ColumnHeader firstNameHeader;
        private System.Windows.Forms.ColumnHeader lastNameHeader;
        private System.Windows.Forms.ColumnHeader emailHeader;
        private System.Windows.Forms.ColumnHeader addressHeader;
        private System.Windows.Forms.ColumnHeader petsHeader;
    }
}
