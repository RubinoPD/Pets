using PETS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETS.UserPages
{
    public partial class UserAdministrationPage : Form
    {
        public UserAdministrationPage()
        {
            InitializeComponent();
            LoadUsers();
        }


        private void LoadUsers()
        {
            List<RegularUser> users = DBConnection.GetAllUsers();
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(user.UserId.ToString());
                item.SubItems.Add(user.FirstName);
                item.SubItems.Add(user.LastName);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.AddressID.ToString());
                item.SubItems.Add(user.PetsID.ToString());
                userListView.Items.Add(item);
            }
        }
    }
}
