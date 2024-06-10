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
        private Form1 _loginForm;
        public adminPage(Admin userInfo, Form1 loginForm)
        {
            InitializeComponent();
            _userInfo = userInfo;
            _loginForm = loginForm;
            
        }

        

        private void label1_Click(object sender, EventArgs e)
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

        private void addClinicBtn_Click(object sender, EventArgs e)
        {
            AddClinicForm addClinicForm = new AddClinicForm();
            addClinicForm.ShowDialog();
        }

        private void addCityBtn_Click(object sender, EventArgs e)
        {
            AddCityForm addCityForm = new AddCityForm();
            addCityForm.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Close the current form and show the login form
            this.Close();
            //Form1 loginForm = new Form1();
            _loginForm.Show();
        }

        private void superAdministration_Click(object sender, EventArgs e)
        {
            SupervisorAdministrationPage supervisorAdministrationPage = new SupervisorAdministrationPage();
            supervisorAdministrationPage.ShowDialog();
        }

        private void addSuperUser_Click(object sender, EventArgs e)
        {
            AddSupervisorForm addSupervisorForm = new AddSupervisorForm();
            addSupervisorForm.ShowDialog();
        }
    }
}
