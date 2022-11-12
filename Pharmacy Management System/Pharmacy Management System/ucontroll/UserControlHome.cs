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
        DispensingClass dc = new DispensingClass();
        ReceivingClass rc = new ReceivingClass();
        CustomerClass hc = new CustomerClass();

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


        public void loadData()
        {
            dc.list();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dc.dtable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                var fullName_address = item[7].ToString() + " - " + item[8].ToString();
                dataGridView1.Rows[n].Cells[0].Value = item[0];
                dataGridView1.Rows[n].Cells[1].Value = DateTime.Parse(item[6].ToString()).ToString("dd MMM yyy");
                dataGridView1.Rows[n].Cells[2].Value = fullName_address;
                dataGridView1.Rows[n].Cells[3].Value = item[3];
            }

        }

        private void UserControlHome_Load(object sender, EventArgs e)
        {
            //Diplay Count Data
            dc.countDispensing();
            countDispensingToday.Text = dc.count.ToString();
            rc.countReceiving();
            countReceivingToday.Text = rc.count.ToString();
            hc.countPatient();
            countPatientToday.Text = hc.count.ToString();

            loadData();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
