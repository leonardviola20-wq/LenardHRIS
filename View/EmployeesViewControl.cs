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
    public partial class EmployeesViewControl : UserControl
    {
        private int _employeeId;

        // Constructor with employeeId
        public EmployeesViewControl(int employeeId)
        {
            InitializeComponent();

            // Prevent flicker
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            _employeeId = employeeId;

            // For now, just show the ID in the title or a label
            lblTitle.Text = $"Employee Details (ID: {_employeeId})";
        }
    }
}
