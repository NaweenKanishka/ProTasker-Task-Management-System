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
    public partial class register : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=E2320152_final_project_db;";
        public register()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(password.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }
                else
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO protaskerusers (username, password) VALUES (@username, @password)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@username", Username.Text);
                        command.Parameters.AddWithValue("@password", password.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration successful!");
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error code
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
