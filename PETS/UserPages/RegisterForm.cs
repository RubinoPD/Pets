using System;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoadCities();
            LoadVets();
        }

        private void LoadCities()
        {
            var cities = DBConnection.GetAllCities();
            cityComboBox.DataSource = cities;
            cityComboBox.DisplayMember = "CityName";
            cityComboBox.ValueMember = "CityID";
        }

        private void LoadVets()
        {
            var vets = DBConnection.GetAllVets();
            vetComboBox.DataSource = vets;
            vetComboBox.DisplayMember = "VetName";
            vetComboBox.ValueMember = "VetID";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string address = addressTextBox.Text;
            int cityID = (int)cityComboBox.SelectedValue;
            string petName = petNameTextBox.Text;
            string breed = breedTextBox.Text;
            string sex = sexComboBox.SelectedItem.ToString();
            int age = int.Parse(ageTextBox.Text);
            int weight = int.Parse(weightTextBox.Text);
            int vetID = (int)vetComboBox.SelectedValue;

            // Create login credentials
            int loginID = DBConnection.AddLogin(email, password);

            if (loginID != -1)
            {
                // Add address
                int addressID = DBConnection.AddAddress(address, cityID);

                if (addressID != -1)
                {
                    // Add pet
                    int petID = DBConnection.AddPet(petName, breed, sex, age, weight, vetID);

                    if (petID != -1)
                    {
                        // Add user
                        bool userAdded = DBConnection.AddUser(name, surname, email, addressID, petID, loginID);

                        if (userAdded)
                        {
                            MessageBox.Show("User registered successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to add pet.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to add address.");
                }
            }
            else
            {
                MessageBox.Show("Failed to create login credentials.");
            }
        }
    }
}
