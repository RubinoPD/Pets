using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;

namespace PETS.Classes
{
    public class DBConnection
    {

        public static string GetConnectionString() 
        {
            string server = "localhost";
            string database = "pets";
            string user = "root";
            string password = "root";

            string connectionString = $"Server={server};Database={database};User Id={user};Password={password};";
            return connectionString;
        }

        public static Address GetAddress(int addressID)
        {
            Address address = null;
            string connectionString = GetConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT adreso_id, adresas, miesto_id FROM adresas WHERE adreso_id=@addressID;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@addressID", addressID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int address_id = reader.GetInt32(reader.GetOrdinal("adreso_id"));
                        string street = reader.GetString(reader.GetOrdinal("adresas"));
                        int cityID = reader.GetInt32(reader.GetOrdinal("miesto_id"));
                        address = new Address(address_id, street, cityID);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            return address;
        }

        public static Pet GetPet(int petID)
        {
            Pet pet = null;
            string connectionString = GetConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT gyvuno_id, gyv_veisle, lytis, amzius, svoris, chip_id, user_id, skiepo_id, vardas FROM gyvunas WHERE gyvuno_id=@petID;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@petID", petID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int pet_id = reader.GetInt32(reader.GetOrdinal("gyvuno_id"));
                        string breed = reader.GetString(reader.GetOrdinal("gyv_veisle"));
                        string sex = reader.GetString(reader.GetOrdinal("lytis"));
                        int age = reader.GetInt32(reader.GetOrdinal("amzius"));
                        int weight = reader.GetInt32(reader.GetOrdinal("svoris"));
                        int chipID = reader.GetInt32(reader.GetOrdinal("chip_id"));
                        int userID = reader.GetInt32(reader.GetOrdinal("user_id"));
                        int vaccineID = reader.GetInt32(reader.GetOrdinal("skiepo_id"));
                        string name = reader.GetString(reader.GetOrdinal("vardas"));
                        pet = new Pet(pet_id, breed, sex, age, weight, chipID, userID, vaccineID, name);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            return pet;
        }
    }

    public class Address
    {
            public int AddressID { get; set; }
            public string Street { get; set; }
            public int CityID { get; set; }

            public Address(int addressID, string street, int cityID)
            {
                AddressID = addressID;
                Street = street;
                CityID = cityID;
            }
    }

    public class Pet
    {
        public int PetID { get; set; }
        public string Breed { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int ChipID { get; set; }
        public int UserID { get; set; }
        public int VaccineID { get; set; }
        public string Name { get; set; }

        public Pet (int petID, string breed, string sex, int age, int weight, int chipID, int userID, int vaccineID, string name)
        {
            PetID = petID;
            Breed = breed;
            Sex = sex;
            Age = age;
            Weight = weight;
            ChipID = chipID;
            UserID = userID;
            VaccineID = vaccineID;
            Name = name;
        }
    }
}
