using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS.Classes
{
    public abstract class User
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Login {  get; set; }
        public string Address {  get; set; }

        public User (string firstName, string lastName, int login, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Login = login;
            Address = address;
        }
    }
}
