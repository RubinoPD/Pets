using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class VetEditForm : Form
    {
        private Vet _vet;
        private List<Clinic> _clinics;

        public VetEditForm(Vet vet)
        {
            InitializeComponent();
            _vet = vet;
            LoadClinics();
            DisplayVetInfo();
        }

        private void LoadClinics()
        {
            _clinics = DBConnection.GetAllClinics();
            clinicComboBox.DataSource = _clinics;
            clinicComboBox.DisplayMember = "ClinicName";
            clinicComboBox.ValueMember = "ClinicID";
        }

        private void DisplayVetInfo()
        {
            vetIdTextBox.Text = _vet.VetID.ToString();
            firstNameTextBox.Text = _vet.VetName;
            lastNameTextBox.Text = _vet.VetLastName;
            clinicComboBox.SelectedValue = _vet.CliniID;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Update vet info
            _vet.VetName = firstNameTextBox.Text;
            _vet.VetLastName = lastNameTextBox.Text;
            _vet.CliniID = (int)clinicComboBox.SelectedValue;

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
