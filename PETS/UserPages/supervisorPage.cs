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
    public partial class supervisorPage : Form
    {

        private Supervisor _userInfo;
        public supervisorPage(Supervisor userInfo)
        {
            InitializeComponent();
            _userInfo = userInfo;
            DisplayUserInfo();

        }

        private void DisplayUserInfo()
        {
            supervisorLabel.Text = _userInfo.FirstName;
        }

        private void supervisorPage_Load(object sender, EventArgs e)
        {

        }
    }
}
