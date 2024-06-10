using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class ClinicEditForm : Form
    {
        private Clinic _clinic;
        private List<City> _cities;

        public ClinicEditForm(Clinic clinic)
        {
            InitializeComponent();
            _clinic = clinic;
            LoadCities();
            DisplayClinicInfo();
        }

        private void LoadCities()
        {
            _cities = DBConnection.GetAllCities();
            clinicCityComboBox.DataSource = _cities;
            clinicCityComboBox.DisplayMember = "CityName";
            clinicCityComboBox.ValueMember = "CityID";
        }

        private void DisplayClinicInfo()
        {
            clinicIdTextBox.Text = _clinic.ClinicID.ToString();
            clinicNameTextBox.Text = _clinic.ClinicName;
            clinicAddressTextBox.Text = _clinic.Address;
            clinicCityComboBox.SelectedValue = _clinic.CityID;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Update clinic info
            _clinic.ClinicName = clinicNameTextBox.Text;
            _clinic.Address = clinicAddressTextBox.Text;
            _clinic.CityID = (int)clinicCityComboBox.SelectedValue;

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
