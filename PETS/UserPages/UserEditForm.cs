using System;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class UserEditForm : Form
    {
        private RegularUser _user;

        public UserEditForm(RegularUser user)
        {
            InitializeComponent();
            _user = user;
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            userIdTextBox.Text = _user.UserId.ToString();
            firstNameTextBox.Text = _user.FirstName;
            lastNameTextBox.Text = _user.LastName;
            emailTextBox.Text = _user.Email;
            addressTextBox.Text = _user.Address;
            petNameTextBox.Text = _user.PetName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            int userID = Convert.ToInt32(userIdTextBox.Text);
            string newEmail = emailTextBox.Text;

            bool emailUpdated = DBConnection.UpdateUserEmail(userID, newEmail);

            if (emailUpdated)
            {
                MessageBox.Show("Email updated successfully!", "Success", MessageBoxButtons.OK);
            } else
            {
                MessageBox.Show("Failed to update user email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Update user info
            _user.FirstName = firstNameTextBox.Text;
            _user.LastName = lastNameTextBox.Text;
            _user.Email = emailTextBox.Text;
            _user.Address = addressTextBox.Text;
            _user.PetName = petNameTextBox.Text;

            // Update user info in the database
            bool success = DBConnection.UpdateUser(_user);
            if (success)
            {
                MessageBox.Show("User information updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update user information.");
            }
        }
    }
}
