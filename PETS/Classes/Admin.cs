using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS.Classes
{
    public class Admin : User
    {

        public int AdminID {  get; set; }
        public int RoleID { get; set; }

        // Constructor for Admin class
        public Admin(string firstName, string lastName, int login_id, int adminID, int roleID)
            : base(firstName, lastName, login_id) // Call to base class constructor
        {
            this.AdminID = adminID;
            this.RoleID = roleID;
        }
    }
}
