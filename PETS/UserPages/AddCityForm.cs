using System;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class AddCityForm : Form
    {
        public AddCityForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string cityName = cityNameTextBox.Text;

            City newCity = new City(0, cityName);

            bool success = DBConnection.AddCity(newCity);
            if (success)
            {
                MessageBox.Show("City added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add city.");
            }
        }
    }
}
