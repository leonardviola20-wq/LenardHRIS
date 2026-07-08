using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenardHRIS.View
{
    public partial class AddEmployeeControl : UserControl
    {
        private int? _employeeId;
        private string _photoPath;
        private FrmMain.EmployeeFilterState _filterState;
        
        public AddEmployeeControl(int employeeId, FrmMain.EmployeeFilterState filterState)
        {
            InitializeComponent();
            _employeeId = employeeId;
            _filterState = filterState;
            LoadEmployeeData();

            // Default placeholder
            PicEmployeePhoto.Image = Image.FromFile(@"D:\201\Blank.png");
            PicEmployeePhoto.SizeMode = PictureBoxSizeMode.Zoom;

            BtnUploadPhoto.Click += BtnUploadPhoto_Click;

            if (_employeeId == null)
            {
                LblAddEmployee.Text = "Create Employee";
            }
            else
            {
                LblAddEmployee.Text = "Update Employee";
                LblAddEmployee.ForeColor = Color.Green;
            }
        }

        private void LoadEmployeeData()
        {
            if (_employeeId == null) return;

            LblAddEmployee.Text = "Update Employee";

            string connStr = ConfigurationManager.ConnectionStrings["HRDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM Employees WHERE EmployeeID=@EmployeeID";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", _employeeId.Value);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Text fields
                            TxtFirstName.Text = reader["FirstName"]?.ToString();
                            TxtMiddleName.Text = reader["MiddleName"]?.ToString();
                            TxtLastName.Text = reader["LastName"]?.ToString();
                            TxtAddress1.Text = reader["Address1"]?.ToString();
                            TxtAddress2.Text = reader["Address2"]?.ToString();
                            TxtBiometricNumber.Text = reader["BiometricNumber"]?.ToString();
                            TxtContactNumber.Text = reader["ContactNumber"]?.ToString();
                            TxtEmailAddress.Text = reader["Email"]?.ToString();
                            TxtEmergencyName.Text = reader["EmergencyContactName"]?.ToString();
                            TxtEmergencyNumber.Text = reader["EmergencyContactNumber"]?.ToString();
                            TxtRemarks.Text = reader["Remarks"]?.ToString();

                            CboDepartment.Text = reader["Department"]?.ToString();
                            CboEmergencyRelation.Text = reader["EmergencyRelationship"]?.ToString();
                            CboEmploymentStatus.Text = reader["EmploymentStatus"]?.ToString();
                            CboGender.Text = reader["Gender"]?.ToString();
                            CboMaritalStatus.Text = reader["MaritalStatus"]?.ToString();
                            CboPosition.Text = reader["Position"]?.ToString();
                            CboStatusDetail.Text = reader["StatusDetail"]?.ToString();

                            MskPagIBIG.Text = reader["PagIBIG"]?.ToString();
                            MskPhilHealth.Text = reader["Philhealth"]?.ToString();
                            MskSSS.Text = reader["SSS"]?.ToString();
                            MskTIN.Text = reader["TIN"]?.ToString();

                            DtpBirthDate.Value = reader["BirthDate"] != DBNull.Value ? Convert.ToDateTime(reader["BirthDate"]) : DateTime.Now;
                            DtpDateStarted.Value = reader["DateStarted"] != DBNull.Value ? Convert.ToDateTime(reader["DateStarted"]) : DateTime.Now;
                            DtpEndDate.Value = reader["EndDate"] != DBNull.Value ? Convert.ToDateTime(reader["EndDate"]) : DateTime.Now;

                            // 🖼️ Photo handling
                            if (reader["Photo"] != DBNull.Value)
                            {
                                byte[] photoBytes = (byte[])reader["Photo"];
                                using (MemoryStream ms = new MemoryStream(photoBytes))
                                {
                                    PicEmployeePhoto.Image = Image.FromStream(ms);
                                    PicEmployeePhoto.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            else
                            {
                                // Fallback to Blank.png
                                PicEmployeePhoto.Image = Image.FromFile(@"D:\201\Blank.png");
                                PicEmployeePhoto.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                    }
                }
            }
        }

        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            // Masks
            MskSSS.Mask = "";
            MskTIN.Mask = "";
            MskPhilHealth.Mask = "";
            MskPagIBIG.Mask = "";

            // Birth Date
            DtpBirthDate.Format = DateTimePickerFormat.Custom;
            DtpBirthDate.CustomFormat = (DtpBirthDate.Value == DateTime.MinValue) ? " " : "MMM dd, yyyy";

            // Date Started
            DtpDateStarted.Format = DateTimePickerFormat.Custom;
            DtpDateStarted.CustomFormat = (DtpDateStarted.Value == DateTime.MinValue) ? " " : "MMM dd, yyyy";

            // End Date
            DtpEndDate.Format = DateTimePickerFormat.Custom;
            DtpEndDate.CustomFormat = (DtpEndDate.Value == DateTime.MinValue) ? " " : "MMM dd, yyyy";

            // Hook events
            MskSSS.Enter += MaskedBox_Enter; MskSSS.Leave += MaskedBox_Leave;
            MskTIN.Enter += MaskedBox_Enter; MskTIN.Leave += MaskedBox_Leave;
            MskPhilHealth.Enter += MaskedBox_Enter; MskPhilHealth.Leave += MaskedBox_Leave;
            MskPagIBIG.Enter += MaskedBox_Enter; MskPagIBIG.Leave += MaskedBox_Leave;

            // ComboBox setup
            CboGender.Items.AddRange(new[] { "Male", "Female", "Other" });
            CboMaritalStatus.Items.AddRange(new[] { "Single", "Married", "Widowed", "Separated" });
            CboEmploymentStatus.Items.AddRange(new[] { "Active", "Inactive" });
            CboStatusDetail.Items.AddRange(new[] { "Regular", "Probationary", "Contractual", "AWOL", "Resigned", "Terminated" });
            CboDepartment.Items.AddRange(new[] { "Greenhills", "Arya 2", "Arya 1", "Shangri-la", "Magnolia", "Yasuo", "Office", "Commissary", "Warehouse", "My Day" });
            CboPosition.Items.AddRange(new[] { "HR", "Accountant", "Purchasing", "IT", "Admin", "Admin Staff", "Store In-Charge", "Kitchen Staff", "Dining Staff", "Sales Staff", "Commissary Staff", "Warehouse Staff", "Driver" });
            CboEmergencyRelation.Items.AddRange(new[] { "Parent", "Spouse", "Sibling", "Child", "Relative", "Guardian", "Friend", "Colleague", "Other" });

            CboEmploymentStatus.SelectedIndexChanged += CboEmploymentStatus_SelectedIndexChanged;
            CboEmploymentStatus.SelectedItem = "Active";

            ApplyEmploymentStatusRules();
        }

        private void MaskedBox_Enter(object sender, EventArgs e)
        {
            var msk = sender as MaskedTextBox;

            if (msk == MskSSS) msk.Mask = "00-0000000-0";
            else if (msk == MskTIN) msk.Mask = "000-000-000-000";
            else if (msk == MskPhilHealth) msk.Mask = "00-000000000-0";
            else if (msk == MskPagIBIG) msk.Mask = "0000-0000-0000";
        }

        private void MaskedBox_Leave(object sender, EventArgs e)
        {
            var msk = sender as MaskedTextBox;

            if (!msk.MaskFull)
            {
                msk.Mask = "";   // remove mask only for this control
                msk.Clear();     // ensures blank display
            }
        }

        // BirthDate
        private void DtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (DtpBirthDate.Checked)
            {
                DtpBirthDate.Format = DateTimePickerFormat.Custom;
                DtpBirthDate.CustomFormat = "MMM dd, yyyy";
            }
            else
            {
                DtpBirthDate.CustomFormat = " ";
            }
        }

        private void CboEmploymentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboEmploymentStatus.SelectedItem != null)
            {
                string status = CboEmploymentStatus.SelectedItem.ToString();

                if (status == "Active")
                {
                    // Disable End Date controls
                    DtpEndDate.Enabled = false;
                    lblEndDate.Enabled = false;

                    // Clear visually without breaking MinDate rule
                    DtpEndDate.Value = DateTime.Today;   // safe default
                    DtpEndDate.CustomFormat = " ";       // shows blank
                }
                else
                {
                    // Enable End Date controls
                    DtpEndDate.Enabled = true;
                    lblEndDate.Enabled = true;

                    DtpEndDate.Format = DateTimePickerFormat.Custom;
                    DtpEndDate.CustomFormat = "MMM dd, yyyy";

                    ApplyEmploymentStatusRules();
                }
            }
        }

        private void BtnNext1_Click(object sender, EventArgs e)
        {
            // Switch directly to TabJobInformation inside TabEmployeDetails
            TabEmployeDetails.SelectedTab = TabJobInformation;
        }
        private void BtnNext2_Click(object sender, EventArgs e)
        {
            // Switch directly to TabJobInformation inside TabEmployeDetails
            TabEmployeDetails.SelectedTab = TabGovernmentInformation;
        }
        private void BtnNext3_Click(object sender, EventArgs e)
        {
            // Switch directly to TabJobInformation inside TabEmployeDetails
            TabEmployeDetails.SelectedTab = TabEmergencyInformation;
        }
        private void BtnPrev1_Click(object sender, EventArgs e)
        {
            // Switch directly back to TabPersonalInfo
            TabEmployeDetails.SelectedTab = TabPersonalInfo;
        }
        private void BtnPrev2_Click(object sender, EventArgs e)
        {
            // Switch directly back to TabPersonalInfo
            TabEmployeDetails.SelectedTab = TabJobInformation;
        }
        private void BtnPrev3_Click(object sender, EventArgs e)
        {
            // Switch directly back to TabPersonalInfo
            TabEmployeDetails.SelectedTab = TabGovernmentInformation;
        }

        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select Employee Photo";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Display in PictureBox
                    PicEmployeePhoto.Image = Image.FromFile(ofd.FileName);
                    PicEmployeePhoto.SizeMode = PictureBoxSizeMode.Zoom;

                    // Save a copy to D:\201
                    string fileName = $"{Guid.NewGuid()}{Path.GetExtension(ofd.FileName)}";
                    string savePath = Path.Combine(@"D:\201\", fileName);
                    File.Copy(ofd.FileName, savePath, true);

                    _photoPath = savePath; // store reference for DB
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["HRDB"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql;

                    if (_employeeId == 0) // Add new
                    {
                        sql = @"INSERT INTO Employees
                (FirstName, MiddleName, LastName, ContactNumber, Email, Address1, Address2,
                 Gender, MaritalStatus, BirthDate, EmergencyContactName, EmergencyContactNumber,
                 EmergencyRelationship, DateStarted, EndDate, BiometricNumber, EmploymentStatus,
                 StatusDetail, Position, Department, Remarks, TIN, SSS, PagIBIG, Philhealth,
                 Photo)
                VALUES
                (@FirstName, @MiddleName, @LastName, @ContactNumber, @Email, @Address1, @Address2,
                 @Gender, @MaritalStatus, @BirthDate, @EmergencyContactName, @EmergencyContactNumber,
                 @EmergencyRelationship, @DateStarted, @EndDate, @BiometricNumber, @EmploymentStatus,
                 @StatusDetail, @Position, @Department, @Remarks, @TIN, @SSS, @PagIBIG, @Philhealth,
                 @Photo)";
                    }
                    else // Update existing
                    {
                        sql = @"UPDATE Employees SET
                FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName,
                ContactNumber=@ContactNumber, Email=@Email,
                Address1=@Address1, Address2=@Address2, Gender=@Gender,
                MaritalStatus=@MaritalStatus, BirthDate=@BirthDate,
                EmergencyContactName=@EmergencyContactName, EmergencyContactNumber=@EmergencyContactNumber,
                EmergencyRelationship=@EmergencyRelationship, DateStarted=@DateStarted, EndDate=@EndDate,
                BiometricNumber=@BiometricNumber, EmploymentStatus=@EmploymentStatus, StatusDetail=@StatusDetail,
                Position=@Position, Department=@Department, Remarks=@Remarks,
                TIN=@TIN, SSS=@SSS, PagIBIG=@PagIBIG, Philhealth=@Philhealth,
                Photo=@Photo
                WHERE EmployeeID=@EmployeeID";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Text parameters
                        cmd.Parameters.AddWithValue("@FirstName", TxtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@MiddleName", TxtMiddleName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", TxtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", TxtContactNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", TxtEmailAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address1", TxtAddress1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address2", TxtAddress2.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", CboGender.Text);
                        cmd.Parameters.AddWithValue("@MaritalStatus", CboMaritalStatus.Text);
                        cmd.Parameters.Add("@BirthDate", SqlDbType.Date).Value = DtpBirthDate.Value;

                        cmd.Parameters.AddWithValue("@EmergencyContactName", TxtEmergencyName.Text.Trim());
                        cmd.Parameters.AddWithValue("@EmergencyContactNumber", TxtEmergencyNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@EmergencyRelationship", CboEmergencyRelation.Text);

                        cmd.Parameters.Add("@DateStarted", SqlDbType.Date).Value = DtpDateStarted.Value;
                        cmd.Parameters.Add("@EndDate", SqlDbType.Date).Value = DtpEndDate.Value;
                        cmd.Parameters.AddWithValue("@BiometricNumber", TxtBiometricNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@EmploymentStatus", CboEmploymentStatus.Text);
                        cmd.Parameters.AddWithValue("@StatusDetail", CboStatusDetail.Text);
                        cmd.Parameters.AddWithValue("@Position", CboPosition.Text);
                        cmd.Parameters.AddWithValue("@Department", CboDepartment.Text);
                        cmd.Parameters.AddWithValue("@Remarks", TxtRemarks.Text.Trim());

                        cmd.Parameters.AddWithValue("@TIN", MskTIN.Text.Trim());
                        cmd.Parameters.AddWithValue("@SSS", MskSSS.Text.Trim());
                        cmd.Parameters.AddWithValue("@PagIBIG", MskPagIBIG.Text.Trim());
                        cmd.Parameters.AddWithValue("@Philhealth", MskPhilHealth.Text.Trim());

                        // Photo handling (binary only)
                        byte[] photoBytes = null;
                        if (PicEmployeePhoto.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                PicEmployeePhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                photoBytes = ms.ToArray();
                            }
                        }
                        cmd.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = (object)photoBytes ?? DBNull.Value;

                        if (_employeeId > 0)
                            cmd.Parameters.AddWithValue("@EmployeeID", _employeeId);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        string action = _employeeId == 0 ? "saved" : "updated";
                        if (rows > 0)
                        {
                            MessageBox.Show($"Employee record {action} successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            var mainForm = this.ParentForm as FrmMain;
                            MessageBox.Show($"Returning with filter state: Branch={_filterState?.BranchId}, Status={_filterState?.StatusId}");
                            mainForm?.ShowEmployeesList(_filterState);
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var mainForm = this.ParentForm as FrmMain;
            MessageBox.Show($"Cancel returning with filter state: Branch={_filterState?.BranchId}, Status={_filterState?.StatusId}");
            mainForm?.ShowEmployeesList(_filterState);
        }

        private void ApplyEmploymentStatusRules()
        {
            if (CboEmploymentStatus.SelectedItem != null)
            {
                string status = CboEmploymentStatus.SelectedItem.ToString();

                if (status == "Active")
                {
                    DtpEndDate.Enabled = false;
                    lblEndDate.Enabled = false;

                    // Safe blank display
                    DtpEndDate.Value = DateTime.Today;   // keep within valid range
                    DtpEndDate.CustomFormat = " ";
                }
                else
                {
                    DtpEndDate.Enabled = true;
                    lblEndDate.Enabled = true;

                    DtpEndDate.Format = DateTimePickerFormat.Custom;
                    DtpEndDate.CustomFormat = "MMM dd, yyyy";
                }
            }
        }

    }
}
