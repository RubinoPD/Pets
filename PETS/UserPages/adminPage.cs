using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PETS.Classes;

namespace PETS.UserPages
{
    public partial class adminPage : Form
    {

        private Admin _userInfo;
        public adminPage(Admin userInfo)
        {
            InitializeComponent();
            _userInfo = userInfo;
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            label1.Text = _userInfo.firstName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
