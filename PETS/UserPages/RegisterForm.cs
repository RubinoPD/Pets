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
            DateTime chipDate = chipDatePicker.Value;

            // Create login credentials
            int loginID = DBConnection.AddLogin(email, password);

            if (loginID != -1)
            {
                // Add address
                int addressID = DBConnection.AddAddress(address, cityID);

                if (addressID != -1)
                {
                    // Add user without petID
                    int userID = DBConnection.AddUser(name, surname, email, addressID, loginID);

                    if (userID != -1)
                    {
                        // Add chip
                        int chipID = DBConnection.AddChip(1, vetID, chipDate); // klinikos_id and vet_id are set to 1

                        if (chipID != -1)
                        {
                            // Add pet with user_id and skiepo_id as default 1
                            int petID = DBConnection.AddPet(petName, breed, sex, age, weight, chipID, userID, vetID, 1);

                            if (petID != -1)
                            {
                                // Update user with petID
                                bool userUpdated = DBConnection.UpdateUserWithPetID(userID, petID);

                                if (userUpdated)
                                {
                                    MessageBox.Show("User and pet registered successfully!");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update user with petID.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Failed to add pet.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to add chip.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to register user.");
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
