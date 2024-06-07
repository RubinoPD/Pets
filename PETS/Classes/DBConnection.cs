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

        public static bool UpdateUser(RegularUser user)
        {
            string connectionString = GetConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE user SET vardas=@FirstName, pavarde=@LastName WHERE user_id=@UserID;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@UserID", user.UserId);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database update failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
        }

        public static bool UpdateAddress(int addressID, Address address)
        {
            string connectionString = GetConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE adresas SET adresas=@Street WHERE adreso_id=@AddressID;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Street", address.Street);
                    cmd.Parameters.AddWithValue("@AddressID", addressID);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database update failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
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
                    string query = "SELECT gyvuno_id, gyv_veisle, lytis, amzius, svoris, chip_id, user_id, skiepo_id, vardas, vet_id FROM gyvunas WHERE gyvuno_id=@petID;";
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
                        int vetID = reader.GetInt32(reader.GetOrdinal("vet_id"));
                        pet = new Pet(pet_id, breed, sex, age, weight, chipID, userID, vaccineID, name, vetID);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            return pet;
        }

        public static Chip GetChip(int chipID)
        {
            Chip chip = null;
            string connectionString = GetConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT chip_id, klinikos_id, vet_id, data FROM cipas WHERE chip_id=@chipID;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@chipID", chipID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int chip_id = reader.GetInt32(reader.GetOrdinal("chip_id"));
                        int clinicID = reader.GetInt32(reader.GetOrdinal("klinikos_id"));
                        int vetID = reader.GetInt32(reader.GetOrdinal("vet_id"));
                        DateTime date = reader.GetDateTime(reader.GetOrdinal("data"));
                        
                        chip = new Chip(chip_id, clinicID, vetID, date);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            return chip;
        }

        public static Vaccine GetVaccine(int vaccineID)
        {
            Vaccine vaccine = null;
            string connectionString = GetConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT skiepo_id, pavadinimas, skiepo_data, kitas_skiepas FROM skiepas WHERE skiepo_id=@vaccineID;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@vaccineID", vaccineID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int vaccine_id = reader.GetInt32(reader.GetOrdinal("skiepo_id"));
                        string name = reader.GetString(reader.GetOrdinal("pavadinimas"));
                        DateTime vaccineDate = reader.GetDateTime(reader.GetOrdinal("skiepo_data"));
                        DateTime nextDate = reader.GetDateTime(reader.GetOrdinal("kitas_skiepas"));

                        vaccine = new Vaccine(vaccine_id, name, vaccineDate, nextDate);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            return vaccine;
        }

        public static Vet GetVet(int vetID)
        {
            Vet vet = null;
            string connectionString = GetConnectionString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT vet_id, vardas, pavarde, klinikos_id FROM veterinaras WHERE vet_id=@vetID;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@vetID", vetID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int vet_id = reader.GetInt32(reader.GetOrdinal("vet_id"));
                        string name = reader.GetString(reader.GetOrdinal("vardas"));
                        string lastName = reader.GetString(reader.GetOrdinal("pavarde"));
                        int clinicID = reader.GetInt32(reader.GetOrdinal("klinikos_id"));

                        vet = new Vet(vetID, name, lastName, clinicID); 
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            return vet;
        }

        public static List<RegularUser> GetAllUsers()
        {
            List<RegularUser> users = new List<RegularUser>();
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT u.user_id, u.vardas, u.pavarde, u.el_pastas, 
                               a.adresas, p.vardas as pet_name
                        FROM user u
                        LEFT JOIN adresas a ON u.adreso_id = a.adreso_id
                        LEFT JOIN gyvunas p ON u.gyvuno_id = p.gyvuno_id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32("user_id");
                            string firstName = reader.GetString("vardas");
                            string lastName = reader.GetString("pavarde");
                            string email = reader.GetString("el_pastas");
                            string address = reader.IsDBNull(reader.GetOrdinal("adresas")) ? "N/A" : reader.GetString("adresas");
                            string petName = reader.IsDBNull(reader.GetOrdinal("pet_name")) ? "N/A" : reader.GetString("pet_name");

                            RegularUser user = new RegularUser(firstName, lastName, 0, userId, 0, email, 0)
                            {
                                Address = address,
                                PetName = petName
                            };
                            users.Add(user);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return users;
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
        public int VetID { get; set; }

        public Pet (int petID, string breed, string sex, int age, int weight, int chipID, int userID, int vaccineID, string name, int vetID)
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
            VetID = vetID;
        }
    }

    public class Chip
    {
        public int ChipID { get; set; }
        public int ClinicID { get; set; }
        public int VetID { get; set; }
        public DateTime Date { get; set; }

        public Chip(int chipID, int clinicID, int vetID, DateTime date)
        {
            ChipID = chipID;
            ClinicID = clinicID;
            VetID = vetID;
            Date = date;
        }
    }

    public class Vaccine
    {
        public int VaccineID { get; set; }
        public string VaccineName { get; set; }
        public DateTime VaccineDate { get; set; }
        public DateTime NextVaccineDate { get; set; }

        public Vaccine(int vaccine_id, string vaccine_name, DateTime vaccine_date, DateTime nextVaccine)
        {
            VaccineID = vaccine_id;
            VaccineName = vaccine_name;
            VaccineDate = vaccine_date;
            NextVaccineDate = nextVaccine;

        }
    }

    public class Vet
    {
        public int VetID { get; set; }
        public string VetName { get; set;}
        public string VetLastName { get; set;}
        public int CliniID { get; set;}


        public Vet(int vetID, string vetName, string vetLastName, int cliniID)
        {
            VetID = vetID;
            VetName = vetName;
            VetLastName = vetLastName;
            CliniID = cliniID;
        }
    }
}
