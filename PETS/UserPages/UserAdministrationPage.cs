using PETS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETS.UserPages
{
    public partial class UserAdministrationPage : Form
    {
        public UserAdministrationPage()
        {
            InitializeComponent();
            LoadUsers();
        }


        private void LoadUsers()
        {
            List<RegularUser> users = DBConnection.GetAllUsers();

            userDataGridView.Rows.Clear();

            foreach (var user in users)
            {
                userDataGridView.Rows.Add(user.UserId, user.FirstName, user.LastName, user.Email, user.Address, user.PetName);
            }
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is part of the "Edit User" column
            if (e.ColumnIndex == userDataGridView.Columns["editUserButtonColumn"].Index && e.RowIndex >= 0)
            {
                int userId = (int)userDataGridView.Rows[e.RowIndex].Cells["userIDColumn"].Value;
                RegularUser user = DBConnection.GetUserById(userId); // Fetch the user details by user ID

                UserEditForm editUserForm = new UserEditForm(user);
                editUserForm.ShowDialog();
                LoadUsers(); // Refresh the user list after editing
            }

            // Check if the clicked cell is part of the "Delete User" column
            else if (e.ColumnIndex == userDataGridView.Columns["deleteUserButtonColumn"].Index && e.RowIndex >= 0)
            {
                int userId = (int)userDataGridView.Rows[e.RowIndex].Cells["userIDColumn"].Value;
                var result = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool success = DBConnection.DeleteUser(userId);
                    if (success)
                    {
                        MessageBox.Show("User deleted successfully.");
                        LoadUsers(); // Refresh the user list after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
