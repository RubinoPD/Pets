using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS.Classes
{
    public class RegularUser 
    {

        public int UserId {get; set;}
        public string Email { get; set;}
        public int AddressID { get; set;}
        public int PetsID {  get; set;}
        public string Address { get; set; } 
        public string PetName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LoginID { get; set; }

        public RegularUser(string firstName, string lastName, int login_id, int userID, int petsID, string email, int addressID)
        
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.LoginID = login_id;
            this.UserId = userID;
            this.Email = email;
            this.AddressID = addressID;
            this.PetsID = petsID;
        }

    }
}
