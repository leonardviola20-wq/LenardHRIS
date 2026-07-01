using System.Data;

namespace LenardHRIS.View
{
    partial class EmployeesListControl
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
            this.components = new System.ComponentModel.Container();
            this.LblEmployees = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.Tlp = new System.Windows.Forms.TableLayoutPanel();
            this.PnlNewEmployees = new System.Windows.Forms.Panel();
            this.LblNewCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlInactiveEmployees = new System.Windows.Forms.Panel();
            this.LblInactiveCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlActiveEmployees = new System.Windows.Forms.Panel();
            this.LblActiveCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlTotalEmployees = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotalCount = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.CboEmploymentStatus = new System.Windows.Forms.ComboBox();
            this.CboBranch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSearchName = new System.Windows.Forms.TextBox();
            this.DgvEmployeesList = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LblPageInfo = new System.Windows.Forms.Label();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.Tlp.SuspendLayout();
            this.PnlNewEmployees.SuspendLayout();
            this.PnlInactiveEmployees.SuspendLayout();
            this.PnlActiveEmployees.SuspendLayout();
            this.PnlTotalEmployees.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployeesList)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblEmployees
            // 
            this.LblEmployees.AutoSize = true;
            this.LblEmployees.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployees.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblEmployees.Location = new System.Drawing.Point(18, 17);
            this.LblEmployees.Name = "LblEmployees";
            this.LblEmployees.Size = new System.Drawing.Size(114, 26);
            this.LblEmployees.TabIndex = 1;
            this.LblEmployees.Text = "Employees";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.BtnAddEmployee);
            this.panel3.Controls.Add(this.BtnExport);
            this.panel3.Controls.Add(this.BtnImport);
            this.panel3.Controls.Add(this.LblEmployees);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 64);
            this.panel3.TabIndex = 3;
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnExport.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExport.Location = new System.Drawing.Point(545, 13);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(97, 36);
            this.BtnExport.TabIndex = 3;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnImport.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.BtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImport.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnImport.Location = new System.Drawing.Point(648, 13);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(97, 36);
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
            this.Tlp.Controls.Add(this.PnlNewEmployees, 3, 0);
            this.Tlp.Controls.Add(this.PnlInactiveEmployees, 2, 0);
            this.Tlp.Controls.Add(this.PnlActiveEmployees, 1, 0);
            this.Tlp.Controls.Add(this.PnlTotalEmployees, 0, 0);
            this.Tlp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tlp.Location = new System.Drawing.Point(0, 64);
            this.Tlp.Name = "Tlp";
            this.Tlp.Padding = new System.Windows.Forms.Padding(3);
            this.Tlp.RowCount = 1;
            this.Tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp.Size = new System.Drawing.Size(898, 112);
            this.Tlp.TabIndex = 4;
            // 
            // PnlNewEmployees
            // 
            this.PnlNewEmployees.BackColor = System.Drawing.Color.Orange;
            this.PnlNewEmployees.Controls.Add(this.LblNewCount);
            this.PnlNewEmployees.Controls.Add(this.label4);
            this.PnlNewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlNewEmployees.Location = new System.Drawing.Point(675, 6);
            this.PnlNewEmployees.Name = "PnlNewEmployees";
            this.PnlNewEmployees.Size = new System.Drawing.Size(217, 100);
            this.PnlNewEmployees.TabIndex = 3;
            // 
            // LblNewCount
            // 
            this.LblNewCount.AutoSize = true;
            this.LblNewCount.BackColor = System.Drawing.Color.Transparent;
            this.LblNewCount.Font = new System.Drawing.Font("Open Sans", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewCount.ForeColor = System.Drawing.Color.Transparent;
            this.LblNewCount.Location = new System.Drawing.Point(120, 23);
            this.LblNewCount.Name = "LblNewCount";
            this.LblNewCount.Size = new System.Drawing.Size(94, 74);
            this.LblNewCount.TabIndex = 4;
            this.LblNewCount.Text = "00";
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
            // PnlInactiveEmployees
            // 
            this.PnlInactiveEmployees.BackColor = System.Drawing.Color.DarkRed;
            this.PnlInactiveEmployees.Controls.Add(this.LblInactiveCount);
            this.PnlInactiveEmployees.Controls.Add(this.label3);
            this.PnlInactiveEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlInactiveEmployees.Location = new System.Drawing.Point(452, 6);
            this.PnlInactiveEmployees.Name = "PnlInactiveEmployees";
            this.PnlInactiveEmployees.Size = new System.Drawing.Size(217, 100);
            this.PnlInactiveEmployees.TabIndex = 2;
            // 
            // LblInactiveCount
            // 
            this.LblInactiveCount.AutoSize = true;
            this.LblInactiveCount.BackColor = System.Drawing.Color.Transparent;
            this.LblInactiveCount.Font = new System.Drawing.Font("Open Sans", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInactiveCount.ForeColor = System.Drawing.Color.Transparent;
            this.LblInactiveCount.Location = new System.Drawing.Point(120, 23);
            this.LblInactiveCount.Name = "LblInactiveCount";
            this.LblInactiveCount.Size = new System.Drawing.Size(94, 74);
            this.LblInactiveCount.TabIndex = 3;
            this.LblInactiveCount.Text = "00";
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
            // PnlActiveEmployees
            // 
            this.PnlActiveEmployees.BackColor = System.Drawing.Color.ForestGreen;
            this.PnlActiveEmployees.Controls.Add(this.LblActiveCount);
            this.PnlActiveEmployees.Controls.Add(this.label2);
            this.PnlActiveEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlActiveEmployees.Location = new System.Drawing.Point(229, 6);
            this.PnlActiveEmployees.Name = "PnlActiveEmployees";
            this.PnlActiveEmployees.Size = new System.Drawing.Size(217, 100);
            this.PnlActiveEmployees.TabIndex = 1;
            // 
            // LblActiveCount
            // 
            this.LblActiveCount.AutoSize = true;
            this.LblActiveCount.BackColor = System.Drawing.Color.Transparent;
            this.LblActiveCount.Font = new System.Drawing.Font("Open Sans", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActiveCount.ForeColor = System.Drawing.Color.Transparent;
            this.LblActiveCount.Location = new System.Drawing.Point(120, 23);
            this.LblActiveCount.Name = "LblActiveCount";
            this.LblActiveCount.Size = new System.Drawing.Size(94, 74);
            this.LblActiveCount.TabIndex = 2;
            this.LblActiveCount.Text = "00";
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
            // PnlTotalEmployees
            // 
            this.PnlTotalEmployees.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlTotalEmployees.Controls.Add(this.label1);
            this.PnlTotalEmployees.Controls.Add(this.LblTotalCount);
            this.PnlTotalEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTotalEmployees.Location = new System.Drawing.Point(6, 6);
            this.PnlTotalEmployees.Name = "PnlTotalEmployees";
            this.PnlTotalEmployees.Size = new System.Drawing.Size(217, 100);
            this.PnlTotalEmployees.TabIndex = 0;
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
            // LblTotalCount
            // 
            this.LblTotalCount.AutoSize = true;
            this.LblTotalCount.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalCount.Font = new System.Drawing.Font("Open Sans", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCount.ForeColor = System.Drawing.Color.Transparent;
            this.LblTotalCount.Location = new System.Drawing.Point(120, 23);
            this.LblTotalCount.Name = "LblTotalCount";
            this.LblTotalCount.Size = new System.Drawing.Size(94, 74);
            this.LblTotalCount.TabIndex = 1;
            this.LblTotalCount.Text = "00";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.BtnReset);
            this.panel6.Controls.Add(this.CboEmploymentStatus);
            this.panel6.Controls.Add(this.CboBranch);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.TxtSearchName);
            this.panel6.Location = new System.Drawing.Point(6, 176);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(886, 70);
            this.panel6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(444, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Branch";
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(10, 31);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(30, 30);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "🔄";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // CboEmploymentStatus
            // 
            this.CboEmploymentStatus.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEmploymentStatus.FormattingEnabled = true;
            this.CboEmploymentStatus.Location = new System.Drawing.Point(444, 31);
            this.CboEmploymentStatus.Name = "CboEmploymentStatus";
            this.CboEmploymentStatus.Size = new System.Drawing.Size(149, 30);
            this.CboEmploymentStatus.TabIndex = 3;
            this.CboEmploymentStatus.SelectedIndexChanged += new System.EventHandler(this.CboEmploymentStatus_SelectedIndexChanged);
            // 
            // CboBranch
            // 
            this.CboBranch.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBranch.FormattingEnabled = true;
            this.CboBranch.Location = new System.Drawing.Point(289, 31);
            this.CboBranch.Name = "CboBranch";
            this.CboBranch.Size = new System.Drawing.Size(149, 30);
            this.CboBranch.TabIndex = 2;
            this.CboBranch.SelectedIndexChanged += new System.EventHandler(this.CboBranch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search and Filters";
            // 
            // TxtSearchName
            // 
            this.TxtSearchName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchName.Location = new System.Drawing.Point(42, 32);
            this.TxtSearchName.Name = "TxtSearchName";
            this.TxtSearchName.Size = new System.Drawing.Size(241, 29);
            this.TxtSearchName.TabIndex = 0;
            // 
            // DgvEmployeesList
            // 
            this.DgvEmployeesList.AllowUserToAddRows = false;
            this.DgvEmployeesList.AllowUserToResizeColumns = false;
            this.DgvEmployeesList.AllowUserToResizeRows = false;
            this.DgvEmployeesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvEmployeesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEmployeesList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DgvEmployeesList.ColumnHeadersHeight = 30;
            this.DgvEmployeesList.Location = new System.Drawing.Point(6, 253);
            this.DgvEmployeesList.Margin = new System.Windows.Forms.Padding(6);
            this.DgvEmployeesList.Name = "DgvEmployeesList";
            this.DgvEmployeesList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvEmployeesList.RowTemplate.Height = 30;
            this.DgvEmployeesList.Size = new System.Drawing.Size(886, 357);
            this.DgvEmployeesList.TabIndex = 6;
            this.DgvEmployeesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmployeesList_CellClick);
            this.DgvEmployeesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmployeesList_CellContentClick);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.LblPageInfo);
            this.panel7.Controls.Add(this.BtnPrev);
            this.panel7.Controls.Add(this.BtnNext);
            this.panel7.Location = new System.Drawing.Point(0, 619);
            this.panel7.Name = "panel7";
            this.panel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel7.Size = new System.Drawing.Size(898, 30);
            this.panel7.TabIndex = 8;
            // 
            // LblPageInfo
            // 
            this.LblPageInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPageInfo.AutoSize = true;
            this.LblPageInfo.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPageInfo.Location = new System.Drawing.Point(416, 2);
            this.LblPageInfo.Name = "LblPageInfo";
            this.LblPageInfo.Size = new System.Drawing.Size(84, 17);
            this.LblPageInfo.TabIndex = 2;
            this.LblPageInfo.Text = "Page 00 of 00";
            // 
            // BtnPrev
            // 
            this.BtnPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPrev.Location = new System.Drawing.Point(377, -1);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(33, 23);
            this.BtnPrev.TabIndex = 1;
            this.BtnPrev.Text = "◀";
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNext.Location = new System.Drawing.Point(506, -1);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(33, 23);
            this.BtnNext.TabIndex = 0;
            this.BtnNext.Text = "▶ ";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddEmployee.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAddEmployee.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEmployee.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddEmployee.Location = new System.Drawing.Point(751, 13);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(138, 36);
            this.BtnAddEmployee.TabIndex = 4;
            this.BtnAddEmployee.Text = "Add Employee";
            this.BtnAddEmployee.UseVisualStyleBackColor = false;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // EmployeesListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.DgvEmployeesList);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Tlp);
            this.Controls.Add(this.panel3);
            this.Name = "EmployeesListControl";
            this.Size = new System.Drawing.Size(898, 650);
            this.Load += new System.EventHandler(this.EmployeesView_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Tlp.ResumeLayout(false);
            this.PnlNewEmployees.ResumeLayout(false);
            this.PnlNewEmployees.PerformLayout();
            this.PnlInactiveEmployees.ResumeLayout(false);
            this.PnlInactiveEmployees.PerformLayout();
            this.PnlActiveEmployees.ResumeLayout(false);
            this.PnlActiveEmployees.PerformLayout();
            this.PnlTotalEmployees.ResumeLayout(false);
            this.PnlTotalEmployees.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployeesList)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblEmployees;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel Tlp;
        private System.Windows.Forms.Panel PnlNewEmployees;
        private System.Windows.Forms.Panel PnlInactiveEmployees;
        private System.Windows.Forms.Panel PnlActiveEmployees;
        private System.Windows.Forms.Panel PnlTotalEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView DgvEmployeesList;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox TxtSearchName;
        private System.Windows.Forms.ComboBox CboEmploymentStatus;
        private System.Windows.Forms.ComboBox CboBranch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Label LblPageInfo;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblInactiveCount;
        private System.Windows.Forms.Label LblActiveCount;
        private System.Windows.Forms.Label LblTotalCount;
        private System.Windows.Forms.Label LblNewCount;
        private System.Windows.Forms.Button BtnAddEmployee;
    }
}
