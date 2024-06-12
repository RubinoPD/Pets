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

        // Add methods

        public static bool AddVet(Vet vet)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO veterinaras (vardas, pavarde, klinikos_id) VALUES (@FirstName, @LastName, @ClinicID)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FirstName", vet.VetName);
                    cmd.Parameters.AddWithValue("@LastName", vet.VetLastName);
                    cmd.Parameters.AddWithValue("@ClinicID", vet.CliniID);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database insertion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool AddClinic(Clinic clinic)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO klinikos (pavadinimas, adresas, miesto_id) VALUES (@ClinicName, @Address, @CityID)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ClinicName", clinic.ClinicName);
                    cmd.Parameters.AddWithValue("@Address", clinic.Address);
                    cmd.Parameters.AddWithValue("@CityID", clinic.CityID);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database insertion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool AddCity(City city)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO miestai (pavadinimas) VALUES (@CityName)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@CityName", city.CityName);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database insertion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static int AddLogin(string email, string password)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO login (email_address, password) VALUES (@Email, @Password); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int loginId = Convert.ToInt32(cmd.ExecuteScalar());
                    return loginId;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database insertion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
        }

        public static bool AddSupervisor(Supervisor supervisor)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO supervisor (name, surname, phone_nmb, login_id, role_id, email) VALUES (@Name, @Surname, @Phone, @LoginID, @RoleID, @Email)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Name", supervisor.FirstName);
                    cmd.Parameters.AddWithValue("@Surname", supervisor.LastName);
                    cmd.Parameters.AddWithValue("@Phone", supervisor.PhoneNumber);
                    cmd.Parameters.AddWithValue("@LoginID", supervisor.Login);
                    cmd.Parameters.AddWithValue("@RoleID", supervisor.RoleID);
                    cmd.Parameters.AddWithValue("@Email", supervisor.Email);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database insertion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static int AddAddress(string address, int cityID)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO adresas (adresas, miesto_id) VALUES (@Address, @CityID); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@CityID", cityID);
                    int addressID = Convert.ToInt32(cmd.ExecuteScalar());
                    return addressID;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database insertion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
        }

        // Breed = suo, kate, papuga etc. (naming is hard)

        public static int AddPet(string name, string breed, string sex, int age, int weight, int chipID, int userID, int vetID, int skiepoID)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO gyvunas (vardas, gyv_veisle, lytis, amzius, svoris, chip_id, user_id, vet_id, skiepo_id) VALUES (@Name, @Breed, @Sex, @Age, @Weight, @ChipID, @UserID, @VetID, @SkiepoID); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Breed", breed);
                    cmd.Parameters.AddWithValue("@Sex", sex);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@ChipID", chipID);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@VetID", vetID);
                    cmd.Parameters.AddWithValue("@SkiepoID", skiepoID);
                    int petID = Convert.ToInt32(cmd.ExecuteScalar());
                    return petID;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database insertion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
        }

        public static int AddUser(string name, string surname, string email, int addressID, int loginID)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO user (vardas, pavarde, el_pastas, adreso_id, login_id) VALUES (@Name, @Surname, @Email, @AddressID, @LoginID); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@AddressID", addressID);
                    cmd.Parameters.AddWithValue("@LoginID", loginID);
                    int userID = Convert.ToInt32(cmd.ExecuteScalar());
                    return userID;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database insertion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
        }


        public static int AddChip(int klinikosID, int vetID, DateTime date)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO cipas (klinikos_id, vet_id, data) VALUES (@KlinikosID, @VetID, @Date); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@KlinikosID", klinikosID);
                    cmd.Parameters.AddWithValue("@VetID", vetID);
                    cmd.Parameters.AddWithValue("@Date", date);
                    int chipID = Convert.ToInt32(cmd.ExecuteScalar());
                    return chipID;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database insertion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
        }



        // Update methods

        public static bool UpdateSupervisorEmail(int supervisorId, string newEmail)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Get login_id associated with the supervisor
                        string getLoginIdQuery = "SELECT login_id FROM supervisor WHERE supervisor_id = @SupervisorId";
                        MySqlCommand getLoginIdCmd = new MySqlCommand(getLoginIdQuery, connection, transaction);
                        getLoginIdCmd.Parameters.AddWithValue("@SupervisorId", supervisorId);
                        int loginId = Convert.ToInt32(getLoginIdCmd.ExecuteScalar());

                        // Update email in the supervisor table
                        string updateSupervisorQuery = "UPDATE supervisor SET email = @NewEmail WHERE supervisor_id = @SupervisorId";
                        MySqlCommand updateSupervisorCmd = new MySqlCommand(updateSupervisorQuery, connection, transaction);
                        updateSupervisorCmd.Parameters.AddWithValue("@NewEmail", newEmail);
                        updateSupervisorCmd.Parameters.AddWithValue("@SupervisorId", supervisorId);
                        updateSupervisorCmd.ExecuteNonQuery();

                        // Update email in the login table
                        string updateLoginQuery = "UPDATE login SET email_address = @NewEmail WHERE login_id = @LoginId";
                        MySqlCommand updateLoginCmd = new MySqlCommand(updateLoginQuery, connection, transaction);
                        updateLoginCmd.Parameters.AddWithValue("@NewEmail", newEmail);
                        updateLoginCmd.Parameters.AddWithValue("@LoginId", loginId);
                        updateLoginCmd.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if there is an error
                        transaction.Rollback();
                        MessageBox.Show("Failed to update supervisor email: " + ex.Message, "Error", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool UpdateUserEmail(int userId, string newEmail)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Get login_id associated with the user
                        string getLoginIdQuery = "SELECT login_id FROM user WHERE user_id = @UserId";
                        MySqlCommand getLoginIdCmd = new MySqlCommand(getLoginIdQuery, connection, transaction);
                        getLoginIdCmd.Parameters.AddWithValue("@UserId", userId);
                        int loginId = Convert.ToInt32(getLoginIdCmd.ExecuteScalar());

                        // Update email in the user table
                        string updateUserQuery = "UPDATE user SET el_pastas = @NewEmail WHERE user_id = @UserId";
                        MySqlCommand updateUserCmd = new MySqlCommand(updateUserQuery, connection, transaction);
                        updateUserCmd.Parameters.AddWithValue("@NewEmail", newEmail);
                        updateUserCmd.Parameters.AddWithValue("@UserId", userId);
                        updateUserCmd.ExecuteNonQuery();

                        // Update email in the login table
                        string updateLoginQuery = "UPDATE login SET email_address = @NewEmail WHERE login_id = @LoginId";
                        MySqlCommand updateLoginCmd = new MySqlCommand(updateLoginQuery, connection, transaction);
                        updateLoginCmd.Parameters.AddWithValue("@NewEmail", newEmail);
                        updateLoginCmd.Parameters.AddWithValue("@LoginId", loginId);
                        updateLoginCmd.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if there is an error
                        transaction.Rollback();
                        MessageBox.Show("Failed to update user email: " + ex.Message, "Error", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool UpdateUser(RegularUser user)
        {
            string connectionString = GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE user SET vardas=@FirstName, pavarde=@LastName, el_pastas=@Email WHERE user_id=@UserID;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
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

        public static bool UpdateVet(Vet vet)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE veterinaras SET vardas = @FirstName, pavarde = @LastName, klinikos_id = @ClinicID WHERE vet_id = @VetID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FirstName", vet.VetName);
                    cmd.Parameters.AddWithValue("@LastName", vet.VetLastName);
                    cmd.Parameters.AddWithValue("@ClinicID", vet.CliniID);
                    cmd.Parameters.AddWithValue("@VetID", vet.VetID);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database update failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool UpdateClinic(Clinic clinic)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE klinikos SET pavadinimas = @ClinicName, adresas=@Address, miesto_id=@CityID WHERE klinikos_id = @ClinicID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ClinicName", clinic.ClinicName);
                    cmd.Parameters.AddWithValue("@Address", clinic.Address);
                    cmd.Parameters.AddWithValue("@CityID", clinic.CityID);
                    cmd.Parameters.AddWithValue("@ClinicID", clinic.ClinicID);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database update failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool UpdateSupervisor(Supervisor supervisor)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE supervisor SET name = @Name, surname = @Surname, phone_nmb = @PhoneNmb, email = @Email WHERE supervisor_id = @SupervisorID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Name", supervisor.FirstName);
                    cmd.Parameters.AddWithValue("@Surname", supervisor.LastName);
                    cmd.Parameters.AddWithValue("@PhoneNmb", supervisor.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", supervisor.Email);
                    cmd.Parameters.AddWithValue("@SupervisorID", supervisor.SupervisorID);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database update failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool UpdateUserWithPetID(int userID, int petID)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE user SET gyvuno_id = @PetID WHERE user_id = @UserID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@PetID", petID);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database update failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        // Get methods

        public static RegularUser GetUserById(int userId)
        {
            RegularUser user = null;
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
                LEFT JOIN gyvunas p ON u.gyvuno_id = p.gyvuno_id
                WHERE u.user_id = @UserId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader.GetString("vardas");
                            string lastName = reader.GetString("pavarde");
                            string email = reader.GetString("el_pastas");
                            string address = reader.IsDBNull(reader.GetOrdinal("adresas")) ? "N/A" : reader.GetString("adresas");
                            string petName = reader.IsDBNull(reader.GetOrdinal("pet_name")) ? "N/A" : reader.GetString("pet_name");

                            user = new RegularUser(firstName, lastName, 0, userId, 0, email, 0)
                            {
                                Address = address,
                                PetName = petName
                            };
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return user;
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
            try
            {
                using (var connection = new MySqlConnection(connectionString))
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
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
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
                    string query = "SELECT * FROM cipas WHERE chip_id=@ChipID;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ChipID", chipID);

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

                        vet = new Vet(vetID, name, lastName, clinicID, ""); 
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

        public static List<Vet> GetAllVets()
        {
            List<Vet> vets = new List<Vet>();
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT vet_id, vardas, pavarde, klinikos_id FROM veterinaras";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int vetId = reader.GetInt32("vet_id");
                        string firstName = reader.GetString("vardas");
                        string lastName = reader.GetString("pavarde");
                        int clinicId = reader.GetInt32("klinikos_id");

                        Vet vet = new Vet(vetId, firstName, lastName, clinicId, "");
                        vets.Add(vet);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return vets;
        }

        public static Vet GetVetById(int vetId)
        {
            Vet vet = null;
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT vet_id, vardas, pavarde, klinikos_id FROM veterinaras WHERE vet_id = @VetId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@VetId", vetId);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int vetID = reader.GetInt32("vet_id");
                        string firstName = reader.GetString("vardas");
                        string lastName = reader.GetString("pavarde");
                        int clinicId = reader.GetInt32("klinikos_id");

                        vet = new Vet(vetID, firstName, lastName, clinicId, "");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return vet;
        }

        public static List<Vet> GetAllVetsWithClinicNames()
        {
            List<Vet> vets = new List<Vet>();
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT v.vet_id, v.vardas, v.pavarde, c.pavadinimas
                FROM veterinaras v
                JOIN klinikos c ON v.klinikos_id = c.klinikos_id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int vetId = reader.GetInt32("vet_id");
                        string firstName = reader.GetString("vardas");
                        string lastName = reader.GetString("pavarde");
                        string clinicName = reader.GetString("pavadinimas");

                        Vet vet = new Vet(vetId, firstName, lastName, 0, clinicName);
                        vets.Add(vet);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return vets;
        }

        public static List<Clinic> GetAllClinics()
        {
            List<Clinic> clinics = new List<Clinic>();
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT k.klinikos_id, k.pavadinimas, k.adresas, m.miesto_id, m.pavadinimas AS city_name
                    FROM klinikos k
                    JOIN miestai m ON k.miesto_id = m.miesto_id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int clinicID = reader.GetInt32("klinikos_id");
                        string clinicName = reader.GetString("pavadinimas");
                        string clinicAddress = reader.GetString("adresas");
                        int cityID = reader.GetInt32("miesto_id");
                        string cityName = reader.GetString("city_name");

                        Clinic clinic = new Clinic(clinicID, clinicName, clinicAddress, cityID, cityName);
                        clinics.Add(clinic);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return clinics;
        }

        public static Clinic GetClinicById(int clinicId)
        {
            Clinic clinic = null;
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT k.klinikos_id, k.pavadinimas, k.adresas, m.miesto_id, m.pavadinimas AS city_name
                    FROM klinikos k
                    JOIN miestai m ON k.miesto_id = m.miesto_id
                    WHERE k.klinikos_id = @ClinicID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ClinicID", clinicId);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = reader.GetInt32("klinikos_id");
                        string name = reader.GetString("pavadinimas");
                        string address = reader.GetString("adresas");
                        int cityID = reader.GetInt32("miesto_id");
                        string cityName = reader.GetString("city_name");

                        clinic = new Clinic(id, name, address, cityID, cityName);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return clinic;
        }

        public static List<City> GetAllCities()
        {
            List<City> cities = new List<City>();
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT miesto_id, pavadinimas FROM miestai";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int cityID = reader.GetInt32("miesto_id");
                        string cityName = reader.GetString("pavadinimas");

                        City city = new City(cityID, cityName);
                        cities.Add(city);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return cities;
        }

        public static List<Supervisor> GetAllSupervisors()
        {
            List<Supervisor> supervisors = new List<Supervisor>();
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT supervisor_id, name, surname, phone_nmb, login_id, role_id, email FROM supervisor";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int supervisorID = reader.GetInt32("supervisor_id");
                        string name = reader.GetString("name");
                        string surname = reader.GetString("surname");
                        int phoneNmb = reader.GetInt32("phone_nmb");
                        int loginID = reader.GetInt32("login_id");
                        int roleID = reader.GetInt32("role_id");
                        string email = reader.GetString("email");

                        Supervisor supervisor = new Supervisor(name, surname, loginID, supervisorID, roleID, phoneNmb, email);
                        supervisors.Add(supervisor);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return supervisors;
        }

        public static Supervisor GetSupervisorById(int supervisorId)
        {
            Supervisor supervisor = null;
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT supervisor_id, name, surname, phone_nmb, login_id, role_id, email FROM supervisor WHERE supervisor_id = @SupervisorID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@SupervisorID", supervisorId);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = reader.GetInt32("supervisor_id");
                        string name = reader.GetString("name");
                        string surname = reader.GetString("surname");
                        int phoneNmb = reader.GetInt32("phone_nmb");
                        int loginID = reader.GetInt32("login_id");
                        int roleID = reader.GetInt32("role_id");
                        string email = reader.GetString("email");

                        supervisor = new Supervisor(name, surname, loginID, id, roleID, phoneNmb, email);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return supervisor;
        }

        public static int GetUserID(string email)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT user_id FROM user WHERE el_pastas = @Email";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database query failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return -1;
            }
        }


        // Delete methods

        public static bool DeleteUser(int userId)
        {
            string connectionString = GetConnectionString();
            MySqlTransaction transaction = null;
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    // Set user's gyvuno_id to NULL to break the foreign key constraint
                    string updateUserQuery = "UPDATE user SET gyvuno_id = NULL WHERE user_id = @UserId";
                    MySqlCommand updateUserCmd = new MySqlCommand(updateUserQuery, connection, transaction);
                    updateUserCmd.Parameters.AddWithValue("@UserId", userId);
                    updateUserCmd.ExecuteNonQuery();

                    // Delete associated pets
                    string deletePetsQuery = "DELETE FROM gyvunas WHERE user_id = @UserId";
                    MySqlCommand deletePetsCmd = new MySqlCommand(deletePetsQuery, connection, transaction);
                    deletePetsCmd.Parameters.AddWithValue("@UserId", userId);
                    deletePetsCmd.ExecuteNonQuery();

                    // Get the login_id for the user
                    int loginId = -1;
                    string getLoginIdQuery = "SELECT login_id FROM user WHERE user_id = @UserId";
                    MySqlCommand getLoginIdCmd = new MySqlCommand(getLoginIdQuery, connection);
                    getLoginIdCmd.Parameters.AddWithValue("@UserId", userId);
                    loginId = Convert.ToInt32(getLoginIdCmd.ExecuteScalar());


                    // Delete the user
                    string deleteUserQuery = "DELETE FROM user WHERE user_id = @UserId";
                    MySqlCommand deleteUserCmd = new MySqlCommand(deleteUserQuery, connection);
                    deleteUserCmd.Parameters.AddWithValue("@UserId", userId);
                    deleteUserCmd.ExecuteNonQuery();

                    // Delete the login information
                    if (loginId != -1)
                    {
                        string deleteLoginQuery = "DELETE FROM login WHERE login_id = @LoginId";
                        MySqlCommand deleteLoginCmd = new MySqlCommand(deleteLoginQuery, connection);
                        deleteLoginCmd.Parameters.AddWithValue("@LoginId", loginId);
                        deleteLoginCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Database deletion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool DeleteVet(int vetId)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM veterinaras WHERE vet_id = @VetId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@VetId", vetId);
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database deletion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool DeleteClinic(int clinicId)
        {
            string connectionString = GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM klinikos WHERE klinikos_id = @ClinicID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ClinicID", clinicId);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database deletion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool DeleteSupervisor(int supervisorId)
        {
            string connectionString = GetConnectionString();
            MySqlTransaction transaction = null;
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    // Get the login_id for the supervisor
                    int loginId = -1;
                    string getLoginIdQuery = "SELECT login_id FROM supervisor WHERE supervisor_id = @SupervisorId";
                    MySqlCommand getLoginIdCmd = new MySqlCommand(getLoginIdQuery, connection);
                    getLoginIdCmd.Parameters.AddWithValue("@SupervisorId", supervisorId);
                    loginId = Convert.ToInt32(getLoginIdCmd.ExecuteScalar());

                    // Delete the supervisor
                    string deleteSupervisorQuery = "DELETE FROM supervisor WHERE supervisor_id = @SupervisorId";
                    MySqlCommand deleteSupervisorCmd = new MySqlCommand(deleteSupervisorQuery, connection);
                    deleteSupervisorCmd.Parameters.AddWithValue("@SupervisorId", supervisorId);
                    deleteSupervisorCmd.ExecuteNonQuery();

                    // Delete the login information
                    if (loginId != -1)
                    {
                        string deleteLoginQuery = "DELETE FROM login WHERE login_id = @LoginId";
                        MySqlCommand deleteLoginCmd = new MySqlCommand(deleteLoginQuery, connection);
                        deleteLoginCmd.Parameters.AddWithValue("@LoginId", loginId);
                        deleteLoginCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Database deletion failed: " + ex.Message, "Error", MessageBoxButtons.OK);
                return false;
            }
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
        public string ClinicName { get; set;}


        public Vet(int vetID, string vetName, string vetLastName, int cliniID, string clinicName)
        {
            VetID = vetID;
            VetName = vetName;
            VetLastName = vetLastName;
            CliniID = cliniID;
            ClinicName = clinicName;
        }
    }
}
