namespace LenardHRIS.View
{
    partial class EmployeesView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblEmployees = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAddEmployees = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.Tlp = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DgvEmployeesList = new System.Windows.Forms.DataGridView();
            this.lblNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblJobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDateStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.Tlp.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployeesList)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEmployees
            // 
            this.LblEmployees.AutoSize = true;
            this.LblEmployees.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblEmployees.Location = new System.Drawing.Point(18, 17);
            this.LblEmployees.Name = "LblEmployees";
            this.LblEmployees.Size = new System.Drawing.Size(96, 23);
            this.LblEmployees.TabIndex = 1;
            this.LblEmployees.Text = "Employees";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.BtnAddEmployees);
            this.panel3.Controls.Add(this.BtnExport);
            this.panel3.Controls.Add(this.BtnImport);
            this.panel3.Controls.Add(this.LblEmployees);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 58);
            this.panel3.TabIndex = 3;
            // 
            // BtnAddEmployees
            // 
            this.BtnAddEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddEmployees.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAddEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEmployees.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnAddEmployees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddEmployees.Location = new System.Drawing.Point(702, 17);
            this.BtnAddEmployees.Name = "BtnAddEmployees";
            this.BtnAddEmployees.Size = new System.Drawing.Size(119, 23);
            this.BtnAddEmployees.TabIndex = 4;
            this.BtnAddEmployees.Text = "Add Employees";
            this.BtnAddEmployees.UseVisualStyleBackColor = false;
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnExport.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnExport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExport.Location = new System.Drawing.Point(540, 17);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 23);
            this.BtnExport.TabIndex = 3;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnImport.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.BtnImport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnImport.Location = new System.Drawing.Point(621, 17);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(75, 23);
            this.BtnImport.TabIndex = 2;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // Tlp
            // 
            this.Tlp.ColumnCount = 4;
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tlp.Controls.Add(this.panel5, 3, 0);
            this.Tlp.Controls.Add(this.panel4, 2, 0);
            this.Tlp.Controls.Add(this.panel2, 1, 0);
            this.Tlp.Controls.Add(this.panel1, 0, 0);
            this.Tlp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tlp.Location = new System.Drawing.Point(0, 58);
            this.Tlp.Name = "Tlp";
            this.Tlp.Padding = new System.Windows.Forms.Padding(3);
            this.Tlp.RowCount = 1;
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp.Size = new System.Drawing.Size(827, 112);
            this.Tlp.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(621, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Newly Hired:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(416, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 100);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inactive:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(211, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 100);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Active:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Employees:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 170);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(827, 73);
            this.panel6.TabIndex = 5;
            // 
            // DgvEmployeesList
            // 
            this.DgvEmployeesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvEmployeesList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DgvEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvEmployeesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lblNo,
            this.lblFullName,
            this.lblJobTitle,
            this.lblStatus,
            this.lblBranch,
            this.lblDateStarted,
            this.lblRemarks});
            this.DgvEmployeesList.Location = new System.Drawing.Point(6, 249);
            this.DgvEmployeesList.Margin = new System.Windows.Forms.Padding(6);
            this.DgvEmployeesList.Name = "DgvEmployeesList";
            this.DgvEmployeesList.Size = new System.Drawing.Size(815, 194);
            this.DgvEmployeesList.TabIndex = 6;
            // 
            // lblNo
            // 
            this.lblNo.HeaderText = "No";
            this.lblNo.Name = "lblNo";
            this.lblNo.Width = 35;
            // 
            // lblFullName
            // 
            this.lblFullName.HeaderText = "FullName";
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Width = 230;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.HeaderText = "Job Title";
            this.lblJobTitle.Name = "lblJobTitle";
            // 
            // lblStatus
            // 
            this.lblStatus.HeaderText = "Status";
            this.lblStatus.Name = "lblStatus";
            // 
            // lblBranch
            // 
            this.lblBranch.HeaderText = "Branch";
            this.lblBranch.Name = "lblBranch";
            // 
            // lblDateStarted
            // 
            this.lblDateStarted.HeaderText = "Date Started";
            this.lblDateStarted.Name = "lblDateStarted";
            // 
            // lblRemarks
            // 
            this.lblRemarks.HeaderText = "Remarks";
            this.lblRemarks.Name = "lblRemarks";
            // 
            // EmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.DgvEmployeesList);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Tlp);
            this.Controls.Add(this.panel3);
            this.Name = "EmployeesView";
            this.Size = new System.Drawing.Size(827, 477);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Tlp.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployeesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblEmployees;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel Tlp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView DgvEmployeesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblDateStarted;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblRemarks;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Button BtnAddEmployees;
        private System.Windows.Forms.Button BtnExport;
    }
}
