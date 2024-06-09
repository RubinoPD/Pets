using System;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class ClinicEditForm : Form
    {
        private Clinic _clinic;

        public ClinicEditForm(Clinic clinic)
        {
            InitializeComponent();
            _clinic = clinic;
            DisplayClinicInfo();
        }

        private void DisplayClinicInfo()
        {
            clinicIdTextBox.Text = _clinic.ClinicID.ToString();
            clinicNameTextBox.Text = _clinic.ClinicName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Update clinic info
            _clinic.ClinicName = clinicNameTextBox.Text;

            // Update clinic info in the database
            bool success = DBConnection.UpdateClinic(_clinic);
            if (success)
            {
                MessageBox.Show("Clinic information updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update clinic information.");
            }
        }
    }
}
