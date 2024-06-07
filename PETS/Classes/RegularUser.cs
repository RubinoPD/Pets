using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETS.Classes
{
    public class RegularUser : User
    {

        public int UserId {get; set;}
        public string Email { get; set;}
        public int AddressID { get; set;}
        public int PetsID {  get; set;}
        public string Address { get; set; } 
        public string PetName { get; set; }

        public RegularUser(string firstName, string lastName, int login_id, int userID, int petsID, string email, int addressID)
            : base(firstName, lastName, login_id) // Call to base class constructor
        {
            this.UserId = userID;
            this.Email = email;
            this.AddressID = addressID;
            this.PetsID = petsID;
        }

    }
}
