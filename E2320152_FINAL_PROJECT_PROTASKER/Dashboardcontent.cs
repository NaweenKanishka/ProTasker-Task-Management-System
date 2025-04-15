using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.Reflection;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace E2320152_FINAL_PROJECT_PROTASKER
{
    public partial class Dashboardcontent : UserControl
    {   // MySQL connection
        string connectionString = "server=localhost;user id=root;password=;database=E2320152_final_project_db;";
        public Dashboardcontent()
        {
            InitializeComponent();
        }

        private void Dashboardcontent_Load(object sender, EventArgs e)
        {
            try
            {

                guna2DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


                guna2DataGridView1.Rows.Clear();



                // Create DataGridView columns
                guna2DataGridView1.Columns.Add("tid", "ID");
                guna2DataGridView1.Columns.Add("task_name", "Task");
                guna2DataGridView1.Columns.Add("t_description", "Description");
                guna2DataGridView1.Columns.Add("start_date", "Start Date");
                guna2DataGridView1.Columns.Add("due_date", "Due Date");
                guna2DataGridView1.Columns.Add("priority", "Priority");

                guna2DataGridView1.Columns["t_description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                

                // Edit Image Column
                DataGridViewImageColumn editCol = new DataGridViewImageColumn();
                editCol.Name = "Edit";
                // editCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                 guna2DataGridView1.Columns.Add(editCol);

                // Delete Image Column
                DataGridViewImageColumn deleteCol = new DataGridViewImageColumn();
                deleteCol.Name = "Delete";
                //deleteCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                guna2DataGridView1.Columns.Add(deleteCol);

                

                guna2DataGridView1.RowTemplate.Height = 30;
                guna2DataGridView1.Columns["Edit"].Width = 30;
                guna2DataGridView1.Columns["Delete"].Width = 30;


                // Style
                guna2DataGridView1.RowTemplate.Height = 40;
                guna2DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                guna2DataGridView1.Columns["tid"].Width = 50;
                guna2DataGridView1.Columns["task_name"].Width = 120;
                guna2DataGridView1.Columns["t_description"].Width = 250;
                guna2DataGridView1.Columns["start_date"].Width = 100;
                guna2DataGridView1.Columns["due_date"].Width = 100;
                guna2DataGridView1.Columns["priority"].Width = 60;
                guna2DataGridView1.Columns["Edit"].Width = 40;
                guna2DataGridView1.Columns["Delete"].Width = 60;

                // Load image once
                Image editIcon = null;
                Image deleteIcon = null;
                try
                {
                    editIcon = new Bitmap(Image.FromFile("pen.png"), new Size(24, 24));
                    deleteIcon = new Bitmap(Image.FromFile("check.png"), new Size(24, 24));
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Image file not found: " + ex.Message);
                }
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    row.Cells["Edit"].Value = editIcon;
                    row.Cells["Delete"].Value = deleteIcon;
                }

                guna2DataGridView1.Columns["t_description"].Width = 250;

                // Load data from MySQL
                // Load data from MySQL
                try
                {
                    try
                    {
                        List<string> overdueTasks = new List<string>();

                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "SELECT tid, task_name, t_description, start_date, due_date, priority FROM tasks";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            MySqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                string id = reader["tid"].ToString();
                                string task_name = reader["task_name"].ToString();
                                string t_description = reader["t_description"].ToString();
                                string priority = reader["priority"].ToString();

                                // Convert Start Date
                                string startDate = reader["start_date"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["start_date"]).ToString("yyyy-MM-dd")
                                    : string.Empty;

                                // Convert Due Date
                                string dueDate = reader["due_date"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["due_date"]).ToString("yyyy-MM-dd")
                                    : string.Empty;

                                // Skip empty or null rows
                                if (string.IsNullOrWhiteSpace(task_name) || string.IsNullOrWhiteSpace(t_description))
                                {
                                    continue;
                                }

                                // Add data to DataGridView in correct column order
                                int rowIndex = guna2DataGridView1.Rows.Add(id, task_name, t_description, startDate, dueDate, priority);
                                guna2DataGridView1.Rows[rowIndex].Cells["Edit"].Value = editIcon;
                                guna2DataGridView1.Rows[rowIndex].Cells["Delete"].Value = deleteIcon;

                                // Check for overdue task
                                if(DateTime.TryParse(dueDate, out DateTime dueDateValue) && dueDateValue.Date <= DateTime.Now.Date)
                                {
                                    guna2DataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red; // Change background to red
                                    guna2DataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

                                    // Add the task to the overdue list
                                    overdueTasks.Add(task_name + " (ID: " + id + ", Due: " + dueDate + ")");
                                }
                            }

                            reader.Close();
                        }

                        // Show one message box after loading all overdue tasks
                        if (overdueTasks.Count > 0)
                        {
                            MessageBox.Show("⚠ Overdue tasks:\n\n" + string.Join("\n", overdueTasks), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    string taskId = guna2DataGridView1.Rows[e.RowIndex].Cells["tid"].Value.ToString();
                    string taskName = guna2DataGridView1.Rows[e.RowIndex].Cells["task_name"].Value.ToString();
                    string description = guna2DataGridView1.Rows[e.RowIndex].Cells["t_description"].Value.ToString();
                    string startDate = guna2DataGridView1.Rows[e.RowIndex].Cells["start_date"].Value.ToString();
                    string dueDate = guna2DataGridView1.Rows[e.RowIndex].Cells["due_date"].Value.ToString();
                    string priority = guna2DataGridView1.Rows[e.RowIndex].Cells["priority"].Value.ToString();

                    // Create and show the EditTaskForm
                    EditTaskForm editForm = new EditTaskForm(taskId, taskName, description, startDate, dueDate, priority);
                    editForm.ShowDialog();  // Show the form as a dialog to block interaction with the parent form until it's closed
                }
                else if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    guna2DataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

    }
}
