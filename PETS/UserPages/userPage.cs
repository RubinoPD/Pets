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
        public userPage(RegularUser userInfo)
        {
            InitializeComponent();
            _userInfo = userInfo;
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            userLabel.Text = _userInfo.FirstName;
        }

        private void userPage_Load(object sender, EventArgs e)
        {

        }
    }
}
