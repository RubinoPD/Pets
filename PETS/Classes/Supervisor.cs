using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS.Classes
{
    public class Supervisor : User
    {

        public int SupervisorID {  get; set; }
        public int RoleID {  get; set; }
        public int PhoneNumber { get; set; }
        public string Password {  get; set; }



        public Supervisor (string firstName, string lastName, int login_id, int supervisorID, int roleID, int phoneNumber) : base (firstName, lastName, login_id)
        {
            supervisorID = supervisorID;
            PhoneNumber = phoneNumber;
            RoleID = roleID;
        }

    }
}
