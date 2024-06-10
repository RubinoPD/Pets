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

        private Supervisor _supervisorInfo;
        public supervisorPage(Supervisor supervisorInfo)
        {
            InitializeComponent();
            _supervisorInfo = supervisorInfo;
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            supervisorLabel.Text = $"Sveiki prisijunge, {_supervisorInfo.FirstName} {_supervisorInfo.LastName}";
        }

        private void supervisorPage_Load(object sender, EventArgs e)
        {

        }

        private void userAdministration_Click(object sender, EventArgs e)
        {
            UserAdministrationPage userAdministrationPage = new UserAdministrationPage();
            userAdministrationPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VetAdministrationPage vetAdministrationPage = new VetAdministrationPage();
            vetAdministrationPage.ShowDialog();
        }

        private void clinicAdministration_Click(object sender, EventArgs e)
        {
            ClinicAdministrationPage clinicAdministrationPage = new ClinicAdministrationPage();
            clinicAdministrationPage.ShowDialog();
        }

        private void addVetBtn_Click(object sender, EventArgs e)
        {
            AddVetForm addVetForm = new AddVetForm();
            addVetForm.ShowDialog();
        }
    }
}
