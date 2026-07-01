using System.Windows.Forms;

namespace LenardHRIS.View
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.PnlSidebar = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            this.BtnEmployers = new System.Windows.Forms.Button();
            this.BtnEmployees = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.PnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSidebar
            // 
            this.PnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlSidebar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PnlSidebar.Controls.Add(this.BtnSettings);
            this.PnlSidebar.Controls.Add(this.BtnLogout);
            this.PnlSidebar.Controls.Add(this.BtnReports);
            this.PnlSidebar.Controls.Add(this.BtnEmployers);
            this.PnlSidebar.Controls.Add(this.BtnEmployees);
            this.PnlSidebar.Controls.Add(this.BtnDashboard);
            this.PnlSidebar.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.PnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.PnlSidebar.Name = "PnlSidebar";
            this.PnlSidebar.Size = new System.Drawing.Size(200, 450);
            this.PnlSidebar.TabIndex = 0;
            // 
            // BtnSettings
            // 
            this.BtnSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Calibri", 14F);
            this.BtnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSettings.Location = new System.Drawing.Point(0, 221);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSettings.Size = new System.Drawing.Size(200, 37);
            this.BtnSettings.TabIndex = 5;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.UseVisualStyleBackColor = true;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLogout.BackColor = System.Drawing.Color.Navy;
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Calibri", 14F);
            this.BtnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogout.Location = new System.Drawing.Point(0, 413);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnLogout.Size = new System.Drawing.Size(200, 37);
            this.BtnLogout.TabIndex = 4;
            this.BtnLogout.Text = "Log-out";
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnReports.FlatAppearance.BorderSize = 0;
            this.BtnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReports.Font = new System.Drawing.Font("Calibri", 14F);
            this.BtnReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReports.Location = new System.Drawing.Point(0, 178);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReports.Size = new System.Drawing.Size(200, 37);
            this.BtnReports.TabIndex = 3;
            this.BtnReports.Text = "Reports";
            this.BtnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReports.UseVisualStyleBackColor = true;
            // 
            // BtnEmployers
            // 
            this.BtnEmployers.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnEmployers.FlatAppearance.BorderSize = 0;
            this.BtnEmployers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnEmployers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnEmployers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployers.Font = new System.Drawing.Font("Calibri", 14F);
            this.BtnEmployers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEmployers.Location = new System.Drawing.Point(0, 135);
            this.BtnEmployers.Name = "BtnEmployers";
            this.BtnEmployers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEmployers.Size = new System.Drawing.Size(200, 37);
            this.BtnEmployers.TabIndex = 2;
            this.BtnEmployers.Text = "Employers";
            this.BtnEmployers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployers.UseVisualStyleBackColor = true;
            // 
            // BtnEmployees
            // 
            this.BtnEmployees.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnEmployees.FlatAppearance.BorderSize = 0;
            this.BtnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployees.Font = new System.Drawing.Font("Calibri", 14F);
            this.BtnEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEmployees.Location = new System.Drawing.Point(0, 92);
            this.BtnEmployees.Name = "BtnEmployees";
            this.BtnEmployees.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEmployees.Size = new System.Drawing.Size(200, 37);
            this.BtnEmployees.TabIndex = 1;
            this.BtnEmployees.Text = "Employees";
            this.BtnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmployees.UseVisualStyleBackColor = true;
            this.BtnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Calibri", 14F);
            this.BtnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 49);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnDashboard.Size = new System.Drawing.Size(200, 37);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            // 
            // PnlMain
            // 
            this.PnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlMain.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.PnlMain.Location = new System.Drawing.Point(200, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(600, 450);
            this.PnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlSidebar);
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "LenardHRIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSidebar;
        private Button BtnDashboard;
        private Panel PnlMain;
        private Button BtnLogout;
        private Button BtnReports;
        private Button BtnEmployers;
        private Button BtnEmployees;
        private Button BtnSettings;
    }
}
