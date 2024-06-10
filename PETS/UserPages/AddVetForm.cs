using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class AddVetForm : Form
    {
        private List<Clinic> _clinics;

        public AddVetForm()
        {
            InitializeComponent();
            LoadClinics();
        }

        private void LoadClinics()
        {
            _clinics = DBConnection.GetAllClinics();
            clinicComboBox.DataSource = _clinics;
            clinicComboBox.DisplayMember = "ClinicName";
            clinicComboBox.ValueMember = "ClinicID";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            int clinicId = (int)clinicComboBox.SelectedValue;

            Vet newVet = new Vet(0, firstName, lastName, clinicId, "");

            bool success = DBConnection.AddVet(newVet);
            if (success)
            {
                MessageBox.Show("Vet added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add vet.");
            }
        }
    }
}
