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

        public string Address { get; set; }


        public Supervisor (string firstName, string lastName, int login, string address, int supervisorID, int roleID, int phoneNumber, string password) : base (firstName, lastName, login)
        {
            supervisorID = supervisorID;
            PhoneNumber = phoneNumber;
            Password = password;
            RoleID = roleID;
            Address = address;
        }

    }
}
