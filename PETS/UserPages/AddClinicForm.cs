using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class AddClinicForm : Form
    {
        private List<City> _cities;

        public AddClinicForm()
        {
            InitializeComponent();
            LoadCities();
        }

        private void LoadCities()
        {
            _cities = DBConnection.GetAllCities();
            cityComboBox.DataSource = _cities;
            cityComboBox.DisplayMember = "CityName";
            cityComboBox.ValueMember = "CityID";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string clinicName = clinicNameTextBox.Text;
            string address = addressTextBox.Text;
            int cityId = (int)cityComboBox.SelectedValue;

            Clinic newClinic = new Clinic(0, clinicName, address, cityId, ((City)cityComboBox.SelectedItem).CityName);

            bool success = DBConnection.AddClinic(newClinic);
            if (success)
            {
                MessageBox.Show("Clinic added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add clinic.");
            }
        }
    }
}
