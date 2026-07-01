using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LenardHRIS.View
{
    public partial class EmployeesListControl : UserControl
    {
        // 👉 Paging variables go here
        private int _pageSize = 14;
        private int _currentPage = 1;
        private DataTable employeesTable;

        public EmployeesListControl()
        {
            InitializeComponent();
            // Prevent flicker by enabling double buffering
            DgvEmployeesList.DataBindingComplete += DgvEmployeesList_DataBindingComplete;
            LoadEmployees();
            DgvEmployeesList.RowHeadersVisible = false;
            DgvEmployeesList.Resize += (s, e) => AdjustColumnWidths();
            DgvEmployeesList.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 12F, FontStyle.Bold);
            DgvEmployeesList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployeesList.DefaultCellStyle.Font = new Font("Open Sans", 11F, FontStyle.Regular);
            DgvEmployeesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvEmployeesList.AllowUserToResizeColumns = false;
            DgvEmployeesList.AllowUserToResizeRows = false;
            TxtSearchName.TextChanged += TxtSearchName_TextChanged;
            DgvEmployeesList.ScrollBars = ScrollBars.None;
            this.Load += EmployeesView_Load;
            this.DgvEmployeesList.CellContentClick += new DataGridViewCellEventHandler(this.DgvEmployeesList_CellContentClick);
            toolTip1.SetToolTip(BtnReset, "Clear All");
        }

        private void EmployeesView_Load(object sender, EventArgs e)
        {
            // Load employees into the base DataTable
            LoadEmployees();

            // Show first page immediately
            _currentPage = 1;
            LoadPage(_currentPage);

            // Employment Status options
            CboEmploymentStatus.Items.Clear();
            CboEmploymentStatus.Items.Add("All");   // ✅ default option
            CboEmploymentStatus.Items.Add("Active");   // ✅ default option
            CboEmploymentStatus.Items.Add("Inactive");   // ✅ default option
            CboEmploymentStatus.SelectedItem = "Active";

            // Branch options (Departments)
            CboBranch.Items.Clear();
            CboBranch.Items.Add("All");   // ✅ default option
            CboBranch.Items.AddRange(new string[] {"Greenhills", "Arya 2", "Arya 1", "Shangri-la", 
                                                    "Magnolia", "Yasuo", "Office", "Commissary", "Quick Change",
                                                    "Warehouse", "My Day", "Vape" });
            CboBranch.SelectedIndex = 0;  // ✅ default to All

            // Apply filters immediately on load
            _currentPage = 1;
            LoadPage(_currentPage);
        }

        private void LoadPage(int pageNumber)
        {
            if (employeesTable == null) return;

            UpdateSummaryPanels();

            // Build filters
            List<string> filters = new List<string>();

            // 🔎 Search keyword
            if (!string.IsNullOrWhiteSpace(TxtSearchName.Text))
            {
                string keyword = TxtSearchName.Text.Replace("'", "''");
                filters.Add(
                    $"(FullName LIKE '%{keyword}%' OR JobTitle LIKE '%{keyword}%' OR Branch LIKE '%{keyword}%' OR Status LIKE '%{keyword}%' OR Remarks LIKE '%{keyword}%')"
                );
            }

            // 🏢 Branch filter (skip if "All")
            if (CboBranch.SelectedItem != null && CboBranch.SelectedItem.ToString() != "All")
            {
                string branch = CboBranch.SelectedItem.ToString().Replace("'", "''");
                filters.Add($"Branch = '{branch}'");
            }

            // 📋 Employment Status filter (skip if "All")
            if (CboEmploymentStatus.SelectedItem != null && CboEmploymentStatus.SelectedItem.ToString() != "All")
            {
                string status = CboEmploymentStatus.SelectedItem.ToString().Replace("'", "''");
                filters.Add($"Status = '{status}'");
            }

            string combinedFilter = string.Join(" AND ", filters);

            DataView dv = new DataView(employeesTable);
            dv.RowFilter = combinedFilter;

            // Paging
            var pagedData = dv.ToTable().AsEnumerable()
                .Skip((pageNumber - 1) * _pageSize)
                .Take(_pageSize);

            DataTable gridTable = new DataTable();
            gridTable.Columns.Add("EmployeeID");   // ✅ keep ID hidden
            gridTable.Columns.Add("FullName");
            gridTable.Columns.Add("Branch");
            gridTable.Columns.Add("Status");
            gridTable.Columns.Add("JobTitle");
            gridTable.Columns.Add("Started", typeof(DateTime));
            gridTable.Columns.Add("Remarks");

            foreach (DataRow row in pagedData)
            {
                gridTable.Rows.Add(
                    row["EmployeeID"],
                    row["FullName"],
                    row["Branch"],
                    row["Status"],
                    row["JobTitle"],
                    row["DateStarted"],
                    row["Remarks"]
                );
            }

            DgvEmployeesList.DataSource = gridTable;

            // Hide the ID column
            if (DgvEmployeesList.Columns.Contains("EmployeeID"))
                DgvEmployeesList.Columns["EmployeeID"].Visible = false;

            // Renumber rows
            for (int i = 0; i < DgvEmployeesList.Rows.Count; i++)
            {
                DgvEmployeesList.Rows[i].Cells["No"].Value = ((pageNumber - 1) * _pageSize) + i + 1;
            }

            // Update info label
            int totalRecords = dv.Count;
            int totalPages = (int)Math.Ceiling(totalRecords / (double)_pageSize);
            LblPageInfo.Text = $"Page {pageNumber} of {totalPages}";

            // ✅ Refresh navigation buttons immediately
            BtnPrev.Enabled = pageNumber > 1;
            BtnNext.Enabled = pageNumber < totalPages;
        }

        private void DgvEmployeesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (!DgvEmployeesList.Columns.Contains("No"))
            {
                DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn();
                noColumn.Name = "No";
                noColumn.HeaderText = "No";
                noColumn.ReadOnly = true;
                DgvEmployeesList.Columns.Insert(0, noColumn);
                DgvEmployeesList.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            for (int i = 0; i < DgvEmployeesList.Rows.Count; i++)
            {
                DgvEmployeesList.Rows[i].Cells["No"].Value = (i + 1).ToString();
            }
        }

        private void UpdateSummaryPanels()
        {
            if (employeesTable == null) return;

            // Total employees
            int total = employeesTable.Rows.Count;

            // Active employees
            int active = employeesTable.AsEnumerable()
                .Count(r => r["Status"].ToString() == "Active");

            // Inactive employees
            int inactive = employeesTable.AsEnumerable()
                .Count(r => r["Status"].ToString() == "Inactive");

            // Newly hired (example: started within last 30 days)
            int newEmployees = employeesTable.AsEnumerable()
                .Count(r => DateTime.TryParse(r["DateStarted"].ToString(), out DateTime ds) &&
                            ds >= DateTime.Now.AddDays(-30));

            // Assign results to labels
            LblTotalCount.Text = total.ToString();
            LblActiveCount.Text = active.ToString();
            LblInactiveCount.Text = inactive.ToString();
            LblNewCount.Text = newEmployees.ToString();
        }

        private void LoadEmployees()
        {
            string connStr = ConfigurationManager.ConnectionStrings["LenardHRDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"
            SELECT 
                EmployeeID,
                (LastName + ', ' + FirstName) AS FullName,
                Position AS JobTitle,
                EmploymentStatus AS Status,
                Department AS Branch,
                DateStarted,
                Remarks
            FROM Employees
            ORDER BY Department, FullName";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                employeesTable = new DataTable();
                da.Fill(employeesTable);
            }

            _currentPage = 1;
            LoadPage(_currentPage);

            AdjustColumnWidths();
            DgvEmployeesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (DgvEmployeesList.Columns.Contains("EmployeeID"))
                DgvEmployeesList.Columns["EmployeeID"].Visible = false;

            // Rename headers
            if (DgvEmployeesList.Columns.Contains("FullName"))
                DgvEmployeesList.Columns["FullName"].HeaderText = "Full Name";

            if (DgvEmployeesList.Columns.Contains("JobTitle"))
            {
                DgvEmployeesList.Columns["JobTitle"].HeaderText = "Job Title";
                DgvEmployeesList.Columns["JobTitle"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (DgvEmployeesList.Columns.Contains("Status"))
            {
                DgvEmployeesList.Columns["Status"].HeaderText = "Status";
                DgvEmployeesList.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (DgvEmployeesList.Columns.Contains("Branch"))
            {
                DgvEmployeesList.Columns["Branch"].HeaderText = "Branch";
                DgvEmployeesList.Columns["Branch"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (DgvEmployeesList.Columns.Contains("DateStarted"))
            {
                DgvEmployeesList.Columns["DateStarted"].HeaderText = "Started";
                DgvEmployeesList.Columns["DateStarted"].DefaultCellStyle.Format = "MM/dd/yyyy";
                DgvEmployeesList.Columns["DateStarted"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (DgvEmployeesList.Columns.Contains("Remarks"))
                DgvEmployeesList.Columns["Remarks"].HeaderText = "Remarks";

            // Add buttons
            if (!DgvEmployeesList.Columns.Contains("ViewButton"))
            {
                var viewButton = new DataGridViewButtonColumn
                {
                    Name = "ViewButton",
                    HeaderText = " ",
                    Text = "👁",
                    UseColumnTextForButtonValue = true
                };
                DgvEmployeesList.Columns.Add(viewButton);
            }

            if (!DgvEmployeesList.Columns.Contains("UpdateButton"))
            {
                var updateButton = new DataGridViewButtonColumn
                {
                    Name = "UpdateButton",
                    HeaderText = " ",
                    Text = "✐",
                    UseColumnTextForButtonValue = true,
                    DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleCenter }
                };
                DgvEmployeesList.Columns.Add(updateButton);
            }
        }

        private void AdjustColumnWidths()
        {
            if (DgvEmployeesList == null || DgvEmployeesList.Columns.Count == 0)
                return;

            int totalWidth = DgvEmployeesList.ClientSize.Width;

            void SetWidth(string columnName, double percent)
            {
                if (DgvEmployeesList.Columns.Contains(columnName))
                    DgvEmployeesList.Columns[columnName].Width = (int)(totalWidth * percent);
            }

            // Main data columns
            SetWidth("No", 0.05);          // 5%
            SetWidth("FullName", 0.24);    // 24%
            SetWidth("Branch", 0.11);      // 11%
            SetWidth("Status", 0.10);      // 10%
            SetWidth("JobTitle", 0.15);    // 15%
            SetWidth("Started", 0.10); // 10%
            SetWidth("Remarks", 0.15);     // 15%

            // Action buttons at the far right
            SetWidth("ViewButton", 0.05);  // 5%
            SetWidth("UpdateButton", 0.05);// 5%

            // Ensure buttons stay at the far right
            if (DgvEmployeesList.Columns.Contains("ViewButton"))
                DgvEmployeesList.Columns["ViewButton"].DisplayIndex = DgvEmployeesList.Columns.Count - 2;

            if (DgvEmployeesList.Columns.Contains("UpdateButton"))
                DgvEmployeesList.Columns["UpdateButton"].DisplayIndex = DgvEmployeesList.Columns.Count - 1;
        }
                
        private void RenumberRows()
        {
            for (int i = 0; i < DgvEmployeesList.Rows.Count; i++)
            {
                DgvEmployeesList.Rows[i].Cells["No"].Value = ((_currentPage - 1) * _pageSize) + i + 1;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Clear search box
            TxtSearchName.Text = string.Empty;

            // Reset filters back to "All"
            if (CboBranch.Items.Contains("All"))
                CboBranch.SelectedItem = "All";

            if (CboEmploymentStatus.Items.Contains("All"))
                CboEmploymentStatus.SelectedItem = "All";

            // Reset page
            _currentPage = 1;

            // Reload employees with filters applied
            LoadPage(_currentPage);
        }
                
        private void CboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadPage(_currentPage);
        }

        private void CboEmploymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboEmploymentStatus.SelectedItem == null) return;
            _currentPage = 1;
            LoadPage(_currentPage);
        }

        private void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadPage(_currentPage);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadPage(_currentPage);
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadPage(_currentPage);
            }
        }

        private void DgvEmployeesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int employeeId = Convert.ToInt32(DgvEmployeesList.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                var mainForm = this.ParentForm as FrmMain;

                if (DgvEmployeesList.Columns[e.ColumnIndex].Name == "ViewButton")
                {
                    var uc = new EmployeesViewControl(employeeId);
                    mainForm?.ShowControl(uc);   // display in PnlMain
                }
                else if (DgvEmployeesList.Columns[e.ColumnIndex].Name == "UpdateButton")
                {
                    var uc = new AddEmployeeControl(employeeId);
                    mainForm?.ShowControl(uc);   // display in PnlMain
                }
            }
        }

        private void DgvEmployeesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int employeeId = Convert.ToInt32(DgvEmployeesList.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                var mainForm = this.ParentForm as FrmMain;

                if (DgvEmployeesList.Columns[e.ColumnIndex].Name == "ViewButton")
                {
                    var uc = new EmployeesViewControl(employeeId);
                    mainForm?.ShowControl(uc);   // display in PnlMain
                }
                else if (DgvEmployeesList.Columns[e.ColumnIndex].Name == "UpdateButton")
                {
                    var uc = new AddEmployeeControl(employeeId);
                    mainForm?.ShowControl(uc);   // display in PnlMain
                }
            }
        }


        private void ImportEmployeesFromCsv(string filePath)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LenardHRDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string header = sr.ReadLine(); // skip header

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');

                        SqlCommand cmd = new SqlCommand(@"
                    IF EXISTS (SELECT 1 FROM Employees WHERE EmployeeID = @EmployeeID)
                    BEGIN
                        UPDATE Employees
                        SET FirstName = @FirstName,
                            MiddleName = @MiddleName,
                            LastName = @LastName,
                            ContactNumber = @ContactNumber,
                            Email = @Email,
                            Address1 = @Address1,
                            Address2 = @Address2,
                            Gender = @Gender,
                            MaritalStatus = @MaritalStatus,
                            BirthDate = @BirthDate,
                            DateStarted = @DateStarted,
                            EndDate = @EndDate,
                            EmergencyContactName = @EmergencyContactName,
                            EmergencyContactNumber = @EmergencyContactNumber,
                            EmergencyRelationship = @EmergencyRelationship,
                            SSS = @SSS,
                            TIN = @TIN,
                            PhilHealth = @PhilHealth,
                            PagIBIG = @PagIBIG,
                            Department = @Department,
                            Position = @Position,
                            EmploymentStatus = @EmploymentStatus,
                            StatusDetail = @StatusDetail,
                            BiometricNumber = @BiometricNumber,
                            Remarks = @Remarks
                        WHERE EmployeeID = @EmployeeID
                    END
                    ELSE
                    BEGIN
                        INSERT INTO Employees (FirstName, MiddleName, LastName, ContactNumber, Email,
                                               Address1, Address2, Gender, MaritalStatus,
                                               BirthDate, DateStarted, EndDate,
                                               EmergencyContactName, EmergencyContactNumber, EmergencyRelationship,
                                               SSS, TIN, PhilHealth, PagIBIG,
                                               Department, Position, EmploymentStatus, StatusDetail,
                                               BiometricNumber, Remarks)
                        VALUES (@FirstName, @MiddleName, @LastName, @ContactNumber, @Email,
                                @Address1, @Address2, @Gender, @MaritalStatus,
                                @BirthDate, @DateStarted, @EndDate,
                                @EmergencyContactName, @EmergencyContactNumber, @EmergencyRelationship,
                                @SSS, @TIN, @PhilHealth, @PagIBIG,
                                @Department, @Position, @EmploymentStatus, @StatusDetail,
                                @BiometricNumber, @Remarks)
                    END", conn);

                        // EmployeeID
                        cmd.Parameters.AddWithValue("@EmployeeID", int.TryParse(values[0], out int empId) ? empId : -1);

                        // Basic fields
                        cmd.Parameters.AddWithValue("@FirstName", values[1]);
                        cmd.Parameters.AddWithValue("@MiddleName", string.IsNullOrEmpty(values[2]) ? (object)DBNull.Value : values[2]);
                        cmd.Parameters.AddWithValue("@LastName", values[3]);
                        cmd.Parameters.AddWithValue("@ContactNumber", values[4]);
                        cmd.Parameters.AddWithValue("@Email", values[5]);
                        cmd.Parameters.AddWithValue("@Address1", values[6]);
                        cmd.Parameters.AddWithValue("@Address2", values[7]);
                        cmd.Parameters.AddWithValue("@Gender", values[8]);
                        cmd.Parameters.AddWithValue("@MaritalStatus", values[9]);

                        // Dates
                        DateTime parsedDate;
                        cmd.Parameters.AddWithValue("@BirthDate",
                            DateTime.TryParseExact(values[10], "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None, out parsedDate) ? parsedDate : (object)DBNull.Value);

                        cmd.Parameters.AddWithValue("@DateStarted",
                            DateTime.TryParseExact(values[11], "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None, out parsedDate) ? parsedDate : (object)DBNull.Value);

                        cmd.Parameters.AddWithValue("@EndDate",
                            DateTime.TryParseExact(values[12], "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None, out parsedDate) ? parsedDate : (object)DBNull.Value);

                        // Emergency Contact
                        cmd.Parameters.AddWithValue("@EmergencyContactName", values[13]);
                        cmd.Parameters.AddWithValue("@EmergencyContactNumber", values[14]);
                        cmd.Parameters.AddWithValue("@EmergencyRelationship", values[15]);

                        // Government IDs
                        cmd.Parameters.AddWithValue("@SSS", values[16]);
                        cmd.Parameters.AddWithValue("@TIN", values[17]);
                        cmd.Parameters.AddWithValue("@PhilHealth", values[18]);
                        cmd.Parameters.AddWithValue("@PagIBIG", values[19]);

                        // Employment details
                        cmd.Parameters.AddWithValue("@Department", values[20]);
                        cmd.Parameters.AddWithValue("@Position", values[21]);
                        cmd.Parameters.AddWithValue("@EmploymentStatus", values[22]);
                        cmd.Parameters.AddWithValue("@StatusDetail", values[23]);

                        // Biometric + Remarks
                        cmd.Parameters.AddWithValue("@BiometricNumber", values[24]);
                        cmd.Parameters.AddWithValue("@Remarks", values[25]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
              
        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "EmployeesBackup.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportEmployeesToCsv(sfd.FileName);
                        MessageBox.Show("Export completed successfully.", "Export",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Export failed: {ex.Message}", "Export Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void ExportEmployeesToCsv(string filePath)
        {
            string connStr = ConfigurationManager.ConnectionStrings["LenardHRDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"SELECT EmployeeID, FirstName, MiddleName, LastName,
                        ContactNumber, Email,
                        Address1, Address2,
                        Gender, MaritalStatus,
                        BirthDate, DateStarted, EndDate,
                        EmergencyContactName, EmergencyContactNumber, EmergencyRelationship,
                        SSS, TIN, PhilHealth, PagIBIG,
                        Department, Position, EmploymentStatus, StatusDetail,
                        BiometricNumber, Remarks
                 FROM Employees";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // Header row
                    sw.WriteLine("EmployeeID,FirstName,MiddleName,LastName,ContactNumber,Email,Address1,Address2,Gender,MaritalStatus,BirthDate,DateStarted,EndDate,EmergencyContactName,EmergencyContactNumber,EmergencyRelationship,SSS,TIN,PhilHealth,PagIBIG,Department,Position,EmploymentStatus,StatusDetail,BiometricNumber,Remarks");

                    // Data rows
                    while (reader.Read())
                    {
                        string[] fields = new string[26];

                        for (int i = 0; i < 26; i++)
                        {
                            if (reader.IsDBNull(i))
                            {
                                fields[i] = "";
                            }
                            else if (reader[i] is DateTime dt)
                            {
                                fields[i] = dt.ToString("MM/dd/yyyy");
                            }
                            else
                            {
                                string val = reader[i].ToString();

                                // Escape quotes and commas for CSV compliance
                                val = val.Replace("\"", "\"\"");
                                if (val.Contains(",") || val.Contains("\""))
                                    val = "\"" + val + "\"";

                                fields[i] = val;
                            }
                        }

                        sw.WriteLine(string.Join(",", fields));
                    }
                }
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    ImportEmployeesFromCsv(ofd.FileName);

                    LoadEmployees();
                    AdjustColumnWidths();

                    MessageBox.Show("Import completed successfully.", "Import",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Import failed: {ex.Message}", "Import Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            // Create AddEmployeeControl for new employee (use 0 to indicate new)
            var addEmployeeControl = new AddEmployeeControl(0);

            var parentForm = this.FindForm() as FrmMain;
            if (parentForm != null)
            {
                parentForm.ShowControl(addEmployeeControl);
            }
        }
    }
}
