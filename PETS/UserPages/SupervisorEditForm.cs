using System;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class SupervisorEditForm : Form
    {
        private Supervisor _supervisor;

        public SupervisorEditForm(Supervisor supervisor)
        {
            InitializeComponent();
            _supervisor = supervisor;
            DisplaySupervisorInfo();
        }

        private void DisplaySupervisorInfo()
        {
            supervisorIdTextBox.Text = _supervisor.SupervisorID.ToString();
            nameTextBox.Text = _supervisor.FirstName;
            surnameTextBox.Text = _supervisor.LastName;
            phoneTextBox.Text = _supervisor.PhoneNumber.ToString();
            emailTextBox.Text = _supervisor.Email;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            int supervisorId = Convert.ToInt32(supervisorIdTextBox.Text);
            string newEmail = emailTextBox.Text;

            bool emailUpdated = DBConnection.UpdateSupervisorEmail(supervisorId, newEmail);
            if (emailUpdated)
            {
                MessageBox.Show("Email updated successfully!", "Success", MessageBoxButtons.OK);
            } else
            {
                MessageBox.Show("Email failed to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string phoneNumber = _supervisor.PhoneNumber.ToString();
            // Update supervisor info
            _supervisor.FirstName = nameTextBox.Text;
            _supervisor.LastName = surnameTextBox.Text;
            phoneNumber = phoneTextBox.Text;
            _supervisor.Email = emailTextBox.Text;

            // Update supervisor info in the database
            bool success = DBConnection.UpdateSupervisor(_supervisor);
            if (success)
            {
                MessageBox.Show("Supervisor information updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update supervisor information.");
            }
        }
    }
}
