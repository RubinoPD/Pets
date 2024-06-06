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
        }


        private void userPage_Load(object sender, EventArgs e)
        {

        }
    }
}
