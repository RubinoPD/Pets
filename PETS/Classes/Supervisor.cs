using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PETS.Classes
{
    public class Supervisor : User
    {

        public int SupervisorID {  get; set; }
        public int RoleID {  get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }



        public Supervisor (string firstName, string lastName, int login_id, int supervisorID, int roleID, int phoneNumber, string email) : base (firstName, lastName, login_id)
        {
            SupervisorID = supervisorID;
            PhoneNumber = phoneNumber;
            RoleID = roleID;
            Email = email;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
