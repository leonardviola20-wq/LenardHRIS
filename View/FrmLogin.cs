using System;
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
    public partial class FrmLogin : Form
    {
        #region Constructor
        //
        // Constructor (runs automatically when FrmLogin is created)
        //
        public FrmLogin()
        {
            InitializeComponent(); // builds controls from Designer

            // Event wiring: ensures that if the login form is closed,
            // the entire application exits cleanly
            this.FormClosed += (s, args) => Application.Exit();
        }
        #endregion

        #region Event Handlers
        //
        // Event handler for Login button click
        //
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Grab values from textboxes
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Simple admin login check (hardcoded for now)
            if (username == "admin" && password == "1234")
            {
                // Show confirmation message
                MessageBox.Show("Login successful. Welcome, Admin!",
                                "Login Confirmed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Hide login form (so user doesn’t see it anymore)
                this.Hide();

                // Show main form maximized
                FrmMain mainForm = new FrmMain();

                // IMPORTANT: Use Show() instead of ShowDialog()
                // ShowDialog() blocks until FrmMain closes, which is why
                // you couldn’t return to login properly.
                mainForm.Show();

                // Optionally: auto-load DashboardView when FrmMain opens
                mainForm.ShowDashboard();
            }
            else
            {
                // Invalid login feedback
                MessageBox.Show("Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        //
        // Event handler for Cancel button click
        //
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exits the entire app
        }
        #endregion
    }
}