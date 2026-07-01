using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenardHRIS.View
{
    public partial class FrmMain : Form
    {
        // ============================
        // Fields (usually private)
        // ============================
        //private int employeeCount;
        //private string currentUser;

        #region Public Members
        //
        // Constructor
        //
        public FrmMain()
        {
            InitializeComponent(); // <-- always in constructor
        }
        //
        // Public methods (API surface)
        //
        public void ShowDashboard()
        {
            // Clear the panel before adding new content
            PnlMain.Controls.Clear();

            // Create a new DashboardView (UserControl)
            DashboardView dashboard = new DashboardView();

            // Make it fill the panel
            dashboard.Dock = DockStyle.Fill;

            // Add it into PnlMain
            PnlMain.Controls.Add(dashboard);
        }
        #endregion

        #region Private Members
        //
        // Private helpers
        //
        private void LoadEmployees()
        {
            // logic for loading employees
        }
        #endregion

        #region Event Handlers
        //
        // Button click events
        //
        #region Event Handlers
        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            // Clear whatever is currently inside PnlMain
            PnlMain.Controls.Clear();

            // Create a new EmployeesView UserControl
            EmployeesView employeesView = new EmployeesView();

            // Make sure it fills the panel
            employeesView.Dock = DockStyle.Fill;

            // Add it into PnlMain
            PnlMain.Controls.Add(employeesView);
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Set the form to maximize when it loads
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Logout and return to login screen?",
                                         "Confirm Logout",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FrmLogin loginForm = new FrmLogin();
                loginForm.Show();
                this.Hide(); // ✅ hides FrmMain instead of closing it
            }
        }
        #endregion
    }
}

