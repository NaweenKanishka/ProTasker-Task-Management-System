using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace E2320152_FINAL_PROJECT_PROTASKER
{
    public partial class EditTaskForm : Form
    {
        // MySQL connection
        string connectionString = "server=localhost;user id=root;password=;database=E2320152_final_project_db;";
        public EditTaskForm(string taskId, string taskName, string description, string startDate, string dueDate, string priority)
        {
            InitializeComponent();

            txtTaskName.Text = taskName;
            txtDescription.Text = description;
            dateTimePickerStart.Value = DateTime.Parse(startDate);
            dateTimePickerDue.Value = DateTime.Parse(dueDate);
            cmbPriority.SelectedItem = priority;

            lblTaskId.Text = taskId;
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string taskId = lblTaskId.Text;
            string taskName = txtTaskName.Text;
            string description = txtDescription.Text;
            string startDate = dateTimePickerStart.Value.ToString("yyyy-MM-dd");
            string dueDate = dateTimePickerDue.Value.ToString("yyyy-MM-dd");
            string priority = cmbPriority.SelectedItem.ToString();

            string updateQuery = "UPDATE tasks SET task_name=@taskName, t_description=@description, start_date=@startDate, due_date=@dueDate, priority=@priority WHERE tid=@taskId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@taskName", taskName);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@dueDate", dueDate);
                cmd.Parameters.AddWithValue("@priority", priority);
                cmd.Parameters.AddWithValue("@taskId", taskId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Task updated successfully!");
            this.Close();  // Close the edit form after saving
        }
    }
}
