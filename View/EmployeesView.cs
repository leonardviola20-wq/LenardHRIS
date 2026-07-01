using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenardHRIS.View
{
    public partial class EmployeesView : UserControl
    {
        public EmployeesView()
        {
            InitializeComponent();
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
            string connStr = ConfigurationManager.ConnectionStrings["HRDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"SELECT
                            EmployeeID,
                            FirstName, MiddleName, LastName,
                            ContactNumber, Email,
                            Address1, Address2,
                            Gender, MaritalStatus, BirthDate,
                            EmergencyContactName, EmergencyContactNumber, EmergencyRelationship,
                            DateStarted, EndDate, BiometricNumber,
                            EmploymentStatus, StatusDetail,
                            Position, Department,
                            Remarks, PhotoPath,
                            TIN, SSS, PagIBIG, Philhealth
                         FROM Employees";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Write header row
                    sw.WriteLine("EmployeeID,FirstName,MiddleName,LastName,ContactNumber,Email,Address1,Address2,Gender,MaritalStatus,BirthDate,EmergencyContactName,EmergencyContactNumber,EmergencyRelationship,DateStarted,EndDate,BiometricNumber,EmploymentStatus,StatusDetail,Position,Department,Remarks,PhotoPath,TIN,SSS,PagIBIG,Philhealth");

                    // Write data rows
                    while (reader.Read())
                    {
                        string[] fields = new string[26];
                        for (int i = 0; i < 26; i++)
                        {
                            fields[i] = reader[i]?.ToString().Replace(",", " "); // avoid breaking CSV
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
        private void ImportEmployeesFromCsv(string filePath)
        {
            string connStr = ConfigurationManager.ConnectionStrings["HRDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Skip header line
                    string header = sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');

                        SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Employees (
                        EmployeeID,
                        FirstName, MiddleName, LastName,
                        ContactNumber, Email,
                        Address1, Address2,
                        Gender, MaritalStatus, BirthDate,
                        EmergencyContactName, EmergencyContactNumber, EmergencyRelationship,
                        DateStarted, EndDate, BiometricNumber,
                        EmploymentStatus, StatusDetail,
                        Position, Department,
                        Remarks, PhotoPath,
                        TIN, SSS, PagIBIG, Philhealth
                    )
                    VALUES (
                        @EmployeeID,
                        @FirstName, @MiddleName, @LastName,
                        @ContactNumber, @Email,
                        @Address1, @Address2,
                        @Gender, @MaritalStatus, @BirthDate,
                        @EmergencyContactName, @EmergencyContactNumber, @EmergencyRelationship,
                        @DateStarted, @EndDate, @BiometricNumber,
                        @EmploymentStatus, @StatusDetail,
                        @Position, @Department,
                        @Remarks, @PhotoPath,
                        @TIN, @SSS, @PagIBIG, @Philhealth
                    )", conn);

                        // Regular string fields
                        cmd.Parameters.AddWithValue("@FirstName", values[0]);
                        cmd.Parameters.AddWithValue("@MiddleName", values[1]);
                        cmd.Parameters.AddWithValue("@LastName", values[2]);
                        cmd.Parameters.AddWithValue("@ContactNumber", values[3]);
                        cmd.Parameters.AddWithValue("@Email", values[4]);
                        cmd.Parameters.AddWithValue("@Address1", values[5]);
                        cmd.Parameters.AddWithValue("@Address2", values[6]);
                        cmd.Parameters.AddWithValue("@Gender", values[7]);
                        cmd.Parameters.AddWithValue("@MaritalStatus", values[8]);

                        // Date fields with custom format
                        DateTime tempDate;
                        string[] formats = { "MM, dd, yyyy" };

                        if (DateTime.TryParseExact(values[9], formats,
                            System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None,
                            out tempDate))
                            cmd.Parameters.AddWithValue("@BirthDate", tempDate);
                        else
                            cmd.Parameters.AddWithValue("@BirthDate", DBNull.Value);

                        cmd.Parameters.AddWithValue("@EmergencyContactName", values[10]);
                        cmd.Parameters.AddWithValue("@EmergencyContactNumber", values[11]);
                        cmd.Parameters.AddWithValue("@EmergencyRelationship", values[12]);

                        if (DateTime.TryParseExact(values[13], formats,
                            System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None,
                            out tempDate))
                            cmd.Parameters.AddWithValue("@DateStarted", tempDate);
                        else
                            cmd.Parameters.AddWithValue("@DateStarted", DBNull.Value);

                        if (DateTime.TryParseExact(values[14], formats,
                            System.Globalization.CultureInfo.InvariantCulture,
                            System.Globalization.DateTimeStyles.None,
                            out tempDate))
                            cmd.Parameters.AddWithValue("@EndDate", tempDate);
                        else
                            cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);

                        // Remaining fields
                        cmd.Parameters.AddWithValue("@BiometricNumber", values[15]);
                        cmd.Parameters.AddWithValue("@EmploymentStatus", values[16]);
                        cmd.Parameters.AddWithValue("@StatusDetail", values[17]);
                        cmd.Parameters.AddWithValue("@Position", values[18]);
                        cmd.Parameters.AddWithValue("@Department", values[19]);
                        cmd.Parameters.AddWithValue("@Remarks", values[20]);
                        cmd.Parameters.AddWithValue("@PhotoPath", values[21]);
                        cmd.Parameters.AddWithValue("@TIN", values[22]);
                        cmd.Parameters.AddWithValue("@SSS", values[23]);
                        cmd.Parameters.AddWithValue("@PagIBIG", values[24]);
                        cmd.Parameters.AddWithValue("@Philhealth", values[25]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
