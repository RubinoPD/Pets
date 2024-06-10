using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class userPage : Form
    {

        private RegularUser _userInfo;
        private Address _address;
        private Pet _pet;
        private Chip _chip;
        private Vaccine _vaccine;
        private Form1 _loginForm;
        private Vet _vet;
        public userPage(RegularUser userInfo, Form1 loginForm)
        {
            InitializeComponent();
            _userInfo = userInfo;
            _loginForm = loginForm;
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            //userLabel.Text = _userInfo.FirstName;
            userInformationLabel.Text = "Sveiki prisijunge, " + _userInfo.FirstName + " " + _userInfo.LastName + "!";
            userEmailLabel.Text = "Jusu pastas: " + _userInfo.Email;

            // Fetch and display user address
            _address = DBConnection.GetAddress(_userInfo.AddressID);

            if ( _address != null )
            {
                userAdressLabel.Text = $"Jusu adresas: {_address.Street}";
            } else
            {
                userAdressLabel.Text = "Adreso neturite";
            }

            // Fetch and display pet info



            _pet = DBConnection.GetPet(_userInfo.PetsID);
            //_chip = DBConnection.GetChip(_pet.ChipID);
            //_vaccine = DBConnection.GetVaccine(_pet.VaccineID);
            //_vet = DBConnection.GetVet(_pet.VetID);

            if ( _pet != null )
            {
                petsNameLabel.Text = $"Jusu gyvuno vardas: {_pet.Name}";
                petsAgeLabel.Text = $"Jusu gyvuno amzius: {_pet.Age}";
                
                
                

                // Get the chip information
                _chip = DBConnection.GetChip(_pet.ChipID);

                if (_chip != null)
                {
                    petsChipLabel.Text = $"Jusu gyvuno cipo data: {_chip.Date.ToString("MM/dd/yyyy")}";
                } else
                {
                    petsChipLabel.Text = "N/A";
                }

                _vaccine = DBConnection.GetVaccine(_pet.VaccineID);

                if (_vaccine != null )
                {
                    petsVaccineDateLabel.Text = $"Paskutines vakcinacijos data: {_vaccine.VaccineDate.ToString("MM/dd/yyyy")}";
                    petsNextVaccineDateLabel.Text = $"Kitos vakcinacijos data: {_vaccine.NextVaccineDate.ToString("MM/dd/yyyy")}";
                } else
                {
                    petsVaccineDateLabel.Text = "N/A";
                    petsNextVaccineDateLabel.Text = "N/A";
                }

                _vet = DBConnection.GetVet(_pet.VetID);

                if ( _vet != null )
                {
                    petsVetName.Text = $"Veterinaras: {_vet.VetName} {_vet.VetLastName}";
                } else
                {
                    petsVetName.Text = "N/A";
                };

            } else
            {
                petsNameLabel.Text = "Deja, neturite prideto gyvuno";
                petsAgeLabel.Visible = false;
                petsChipLabel.Visible = false;
                petsVaccineDateLabel.Visible = false;
                petsNextVaccineDateLabel.Visible = false;
                petsVetName.Visible = false;
            }

        }


        private void userPage_Load(object sender, EventArgs e)
        {

        }

        private void userEditBtn_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm(_userInfo);
            editUserForm.ShowDialog();
            DisplayUserInfo(); // Refresh the user info after editing
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Close the current form and show the login form
            this.Close();
            //Form1 loginForm = new Form1();
            _loginForm.Show();
        }
    }
}
