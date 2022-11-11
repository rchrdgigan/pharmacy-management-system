using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.ucontroll
{
    public partial class UserControlHome : UserControl
    {

        public static bool is_dispensing_click { get; set; }
        public static bool is_receiving_click { get; set; }
        public static bool is_patient_click { get; set; }

        public UserControlHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            is_dispensing_click = true;
            DasboardForm.b_dispensing.PerformClick();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            is_receiving_click = true;
            DasboardForm.b_receiving.PerformClick();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            is_patient_click = true;
            DasboardForm.b_patient.PerformClick();
        }
    }
}
