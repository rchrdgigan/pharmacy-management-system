﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Pharmacy_Management_System.ucontroll
{
    public partial class UserControlHome : UserControl
    {
        DispensingClass dc = new DispensingClass();
        ReceivingClass rc = new ReceivingClass();
        MedicineClass mc = new MedicineClass();
        CustomerClass hc = new CustomerClass();

        public static bool is_dispensing_click { get; set; }
        public static bool is_receiving_click { get; set; }
        public static bool is_patient_click { get; set; }
        public static string transaction_id { get; set; }

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

        public void loadMedPrescribe()
        {
            
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
            loadMedPrescribe();

            if(dataGridView1.RowCount > 0)
            {
                //Get last transaction id
                transaction_id = dataGridView1.Rows[0].Cells[0].Value.ToString();
                mc.listMedPrescribe(int.Parse(transaction_id));
                List<String> list = new List<String>();
                foreach (DataRow item in mc.dtable.Rows)
                {
                    list.Add(" Medicine: " + item[4].ToString() + "\n" + " Qty: " + item[3].ToString() + " \n");
                }
                richTextBox1.Lines = list.ToArray();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                transaction_id = row.Cells["id"].Value.ToString();
                mc.listMedPrescribe(int.Parse(transaction_id));
                List<String> list = new List<String>();
                foreach (DataRow item in mc.dtable.Rows)
                {
                    list.Add("Medicine: \t" + item[4].ToString()+ "\n" + "Qty: \t" + item[3].ToString() + " \n");
                }
                richTextBox1.Lines = list.ToArray();
            }
            catch
            {

            }
        }
    }
}
