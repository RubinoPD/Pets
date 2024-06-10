using System;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class AddSupervisorForm : Form
    {
        public AddSupervisorForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string phoneNmb = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            int phone = Convert.ToInt32(phoneNmb);


            // Create the login credentials
            int loginId = DBConnection.AddLogin(email, password);

            if (loginId != -1)
            {
                Supervisor newSupervisor = new Supervisor(name, surname, loginId, 0, 2, phone, email);

                bool success = DBConnection.AddSupervisor(newSupervisor);
                if (success)
                {
                    MessageBox.Show("Supervisor added successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add supervisor.");
                }
            }
            else
            {
                MessageBox.Show("Failed to create login credentials.");
            }
        }
    }
}
