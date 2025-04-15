using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2320152_FINAL_PROJECT_PROTASKER
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            this.MaximizeBox = false; // disables maximize button
            this.MinimizeBox = true;  // enables minimize button
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
        private void addUserControls(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Dashboardcontent DC = new Dashboardcontent();
            addUserControls(DC);
        }
        private void LoadDashboard()
        {
            Dashboardcontent dashboardContent = new Dashboardcontent();
            addUserControls(dashboardContent);
        }
    }
}
