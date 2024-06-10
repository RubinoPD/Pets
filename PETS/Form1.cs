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
            string email = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            string connectionString = DBConnection.GetConnectionString();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT login_id, email_address, password FROM login WHERE email_address = @Email AND password = @Password";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            int loginID = reader.GetInt32(0);
                            reader.Close();

                            // Check if the user has admin permissions
                            query = "SELECT * FROM admin WHERE login_id = @loginID";
                            cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@loginID", loginID);

                            using (var reader2 = cmd.ExecuteReader())
                            {
                                if (reader2.HasRows)
                                {
                                    reader2.Read();
                                    int adminID = reader2.GetInt32(reader2.GetOrdinal("admin_id"));
                                    string firstName = reader2.GetString(reader2.GetOrdinal("first_name"));
                                    string lastName = reader2.GetString(reader2.GetOrdinal("last_name"));
                                    int roleID = reader2.GetInt32(reader2.GetOrdinal("role_id"));
                                    int login = reader2.GetInt32(reader2.GetOrdinal("login_id"));
                                    Admin admin = new Admin(firstName, lastName, login, adminID, roleID);
                                    reader2.Close();

                                    adminPage adminPage = new adminPage(admin, this);
                                    adminPage.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    reader2.Close();

                                    // Check if the user has supervisor permissions
                                    query = "SELECT * FROM supervisor WHERE login_id = @loginID";
                                    cmd = new MySqlCommand(query, connection);
                                    cmd.Parameters.AddWithValue("@loginID", loginID);

                                    using (var reader3 = cmd.ExecuteReader())
                                    {
                                        if (reader3.HasRows)
                                        {
                                            reader3.Read();
                                            int supervisorID = reader3.GetInt32(reader3.GetOrdinal("supervisor_id"));
                                            string firstName = reader3.GetString(reader3.GetOrdinal("name"));
                                            string lastName = reader3.GetString(reader3.GetOrdinal("surname"));
                                            int phoneNmb = reader3.GetInt32(reader3.GetOrdinal("phone_nmb"));
                                            int roleID = reader3.GetInt32(reader3.GetOrdinal("role_id"));
                                            int login_id = reader3.GetInt32(reader3.GetOrdinal("login_id"));
                                            string superEmail = reader3.GetString(reader3.GetOrdinal("email"));
                                            Supervisor supervisor = new Supervisor(firstName, lastName, login_id, supervisorID, roleID, phoneNmb, superEmail);
                                            reader3.Close();

                                            supervisorPage supervisorPage = new supervisorPage(supervisor, this);
                                            supervisorPage.Show();
                                            this.Hide();
                                        }
                                        else
                                        {
                                            reader3.Close();

                                            // Check if it is a simple user
                                            query = "SELECT * FROM user WHERE login_id = @loginID";
                                            cmd = new MySqlCommand(query, connection);
                                            cmd.Parameters.AddWithValue("@loginID", loginID);

                                            using (var reader4 = cmd.ExecuteReader())
                                            {
                                                if (reader4.HasRows)
                                                {
                                                    reader4.Read();
                                                    int userID = reader4.GetInt32(reader4.GetOrdinal("user_id"));
                                                    string firstName = reader4.GetString(reader4.GetOrdinal("vardas"));
                                                    string lastName = reader4.GetString(reader4.GetOrdinal("pavarde"));
                                                    string userEmail = reader4.GetString(reader4.GetOrdinal("el_pastas"));
                                                    int login_id = reader4.GetInt32(reader4.GetOrdinal("login_id"));
                                                    int addressID = reader4.GetInt32(reader4.GetOrdinal("adreso_id"));
                                                    int petID = reader4.GetInt32(reader4.GetOrdinal("gyvuno_id"));
                                                    RegularUser user = new RegularUser(firstName, lastName, login_id, petID, userID, userEmail, addressID);
                                                    reader4.Close();

                                                    userPage userPage = new userPage(user, this);
                                                    userPage.Show();
                                                    this.Hide();
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
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        /* private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        } */

        private void registerBtn_Click_1(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}