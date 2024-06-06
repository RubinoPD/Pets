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

    }
