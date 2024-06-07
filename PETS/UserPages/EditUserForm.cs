using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class EditUserForm : Form
    {

        private RegularUser _userInfo;
        private Address _addressInfo;
        public EditUserForm(RegularUser userInfo)
        {
            InitializeComponent();
            _userInfo = userInfo;
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            firstNameTextBox.Text = _userInfo.FirstName;
            lastNameTextBox.Text = _userInfo.LastName;

            _addressInfo = DBConnection.GetAddress(_userInfo.AddressID);
            if (_addressInfo != null)
            {
                addressTextBox.Text = _addressInfo.Street;
            }
        }



        private void EditUserForm_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Update user info
            _userInfo.FirstName = firstNameTextBox.Text;
            _userInfo.LastName = lastNameTextBox.Text;

            // Update address info
            _addressInfo.Street = addressTextBox.Text;
            

            // Update user and address info in the database
            bool userUpdateSuccess = DBConnection.UpdateUser(_userInfo);
            bool addressUpdateSuccess = DBConnection.UpdateAddress(_userInfo.AddressID, _addressInfo);

            if (userUpdateSuccess && addressUpdateSuccess)
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
