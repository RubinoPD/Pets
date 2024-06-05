using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PETS.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using PETS.UserPages;

namespace PETS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void testCon_Click(object sender, EventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Database connection successful!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error");
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            // Check if the fields are not empty
            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                MessageBox.Show("Username field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Password field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check if the user is in database
            string connectionString = DBConnection.GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT login_id FROM login WHERE email_address=@username AND password=@password;";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", usernameTextBox);
                    cmd.Parameters.AddWithValue("@password", passwordTextBox);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string loginID = reader.GetString(0);
                            reader.Close();

                            //Check if the user has admin permissions
                            query = "SELECT * FROM admin WHERE login_id = @loginID;";
                            cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@loginID", loginID);

                            using (MySqlDataReader reader2 = cmd.ExecuteReader())
                            {
                                if (reader2.HasRows)
                                {
                                    reader2.Read();

                                    // Retrieve values from columns
                                    int adminID = reader2.GetInt32(reader2.GetOrdinal("admin_id"));
                                    string firstName = reader2.GetString(reader2.GetOrdinal("first_name"));
                                    string lastName = reader2.GetString(reader2.GetOrdinal("last_name"));
                                    int roleID = reader2.GetInt32(reader2.GetOrdinal("role_id"));
                                    int login = reader2.GetInt32(reader2.GetOrdinal("login_id"));
                                    Admin admin = new Admin(firstName, lastName, login, adminID, roleID);
                                    reader2.Close();

                                    //Open adminPage.xaml page
                                    adminPage adminPage = new adminPage(admin);
                                    adminPage.Show();
                                    this.Hide();
                                    //this.NavigationService.Navigate(adminPage);

                                }
                                else
                                {
                                    reader2.Close();
                                    //Check if the user has manager permissions
                                    query = "SELECT * FROM manager WHERE Login = @loginID;";
                                    cmd = new MySqlCommand(query, connection);
                                    cmd.Parameters.AddWithValue("@loginID", loginID);

                                    using (MySqlDataReader reader3 = cmd.ExecuteReader())
                                    {
                                        if (reader3.HasRows)
                                        {
                                            reader3.Read();
                                            // Retrieve values from columns
                                            int managerID = reader3.GetInt32(reader3.GetOrdinal("ManagerID"));
                                            string firstName = reader3.GetString(reader3.GetOrdinal("FirstName"));
                                            string lastName = reader3.GetString(reader3.GetOrdinal("LastName"));
                                            int roleID = reader3.GetInt32(reader3.GetOrdinal("RoleID"));
                                            int login = reader3.GetInt32(reader3.GetOrdinal("Login"));
                                            Manager manager = new Manager(firstName, lastName, roleID, login, managerID);

                                            reader3.Close();
                                            //Open managerPage.xaml page
                                            ManagerPage managerPage = new ManagerPage(manager);
                                            this.NavigationService.Navigate(managerPage);
                                        }
                                        else
                                        {
                                            reader3.Close();
                                            //Check if it is a simple user
                                            query = "SELECT * FROM person WHERE Login = @loginID;";
                                            cmd = new MySqlCommand(query, connection);
                                            cmd.Parameters.AddWithValue("@loginID", loginID);

                                            using (MySqlDataReader reader4 = cmd.ExecuteReader())
                                            {
                                                if (reader4.HasRows)
                                                {
                                                    reader4.Read();
                                                    // Retrieve values from columns
                                                    int personID = reader4.GetInt32(reader4.GetOrdinal("PersonID"));
                                                    string firstName = reader4.GetString(reader4.GetOrdinal("FirstName"));
                                                    string lastName = reader4.GetString(reader4.GetOrdinal("LastName"));
                                                    int roleID = reader4.GetInt32(reader4.GetOrdinal("RoleID"));
                                                    int login = reader4.GetInt32(reader4.GetOrdinal("Login"));
                                                    int unitID = reader4.GetInt32(reader4.GetOrdinal("UnitID"));
                                                    int contactID = reader4.GetInt32(reader4.GetOrdinal("ContactID"));

                                                    person person = new person(firstName, lastName, roleID, login, personID, unitID, contactID);

                                                    reader4.Close();
                                                    //Open UserPage.xaml page
                                                    UserPage userPage = new UserPage(person);

                                                    this.NavigationService.Navigate(userPage);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Login failed!");
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }

                        else
                        {
                            MessageBox.Show("Login failed!");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
                    }
                }
            }

        }
    }
}
