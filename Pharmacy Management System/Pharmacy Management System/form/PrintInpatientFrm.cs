using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Pharmacy_Management_System.form
{
    public partial class PrintInpatientFrm : Form
    {
        public PrintInpatientFrm()
        {
            InitializeComponent();
        }

        private void PrintDispensingFrm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(reportViewer1);
            reportViewer1.RefreshReport();
            reportViewer1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DasboardForm.p_Navigation.Enabled = true;
            DasboardForm.p_Content.Enabled = true;
            DasboardForm.b_dispensing.PerformClick();
            this.Close();
        }
    }
}
