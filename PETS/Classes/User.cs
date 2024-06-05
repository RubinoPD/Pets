using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS.Classes
{
    public abstract class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Login {  get; set; }
        

        public User (string firstName, string lastName, int login_id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            Login = login_id;
        }
    }
}
