using System;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class VetEditForm : Form
    {
        private Vet _vet;

        public VetEditForm(Vet vet)
        {
            InitializeComponent();
            _vet = vet;
            DisplayVetInfo();
        }

        private void DisplayVetInfo()
        {
            vetIdTextBox.Text = _vet.VetID.ToString();
            firstNameTextBox.Text = _vet.VetName;
            lastNameTextBox.Text = _vet.VetLastName;
            clinicIdTextBox.Text = _vet.CliniID.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Update vet info
            _vet.VetName = firstNameTextBox.Text;
            _vet.VetLastName = lastNameTextBox.Text;
            _vet.CliniID = int.Parse(clinicIdTextBox.Text);

            // Update vet info in the database
            bool success = DBConnection.UpdateVet(_vet);
            if (success)
            {
                MessageBox.Show("Vet information updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update vet information.");
            }
        }
    }
}
