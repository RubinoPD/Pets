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
        public userPage(RegularUser userInfo)
        {
            InitializeComponent();
            _userInfo = userInfo;
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
            _chip = DBConnection.GetChip(_pet.ChipID);
            _vaccine = DBConnection.GetVaccine(_pet.VaccineID);

            if ( _pet != null )
            {
                petsNameLabel.Text = $"Jusu gyvuno vardas: {_pet.Name}";
                petsAgeLabel.Text = $"Jusu gyvuno amzius: {_pet.Age}";
                petsChipLabel.Text = $"Jusu gyvuno cipo data: {_chip.Date.ToString("MM/dd/yyyy")}";
                petsVaccineDateLabel.Text = $"Paskutines vakcinacijos data: {_vaccine.VaccineDate.ToString("MM/dd/yyyy")}";
                petsNextVaccineDateLabel.Text = $"Kitos vakcinacijos data: {_vaccine.NextVaccineDate.ToString("MM/dd/yyyy")}";
            } else
            {
                petsNameLabel.Text = "Deja, neturite prideto gyvuno";
                petsAgeLabel.Visible = false;
                petsChipLabel.Visible = false;
                petsVaccineDateLabel.Visible = false;
                petsNextVaccineDateLabel.Visible= false;
            }

        }


        private void userPage_Load(object sender, EventArgs e)
        {

        }
    }
}
