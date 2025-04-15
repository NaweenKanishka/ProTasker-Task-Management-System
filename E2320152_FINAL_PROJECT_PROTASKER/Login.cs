using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E2320152_FINAL_PROJECT_PROTASKER
{
    public partial class Login : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=E2320152_final_project_db;";
        public Login()
        {
            InitializeComponent();
        }

        private void SIGNUP_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                register register = new register();
                register.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Signinbtn_Click(object sender, EventArgs e)
        {
            try
            {
               if(string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(password.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM protaskerusers WHERE username = @username AND password = @password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", Username.Text);
                    command.Parameters.AddWithValue("@password", password.Text);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
