using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pharmacy_Management_System.form
{
    public partial class DispensingFrm : Form
    {
        ConnectionClass cc = new ConnectionClass();
        DispensingClass dc = new DispensingClass();
        InventoryClass ic = new InventoryClass();
        CustomerClass pc = new CustomerClass();
        MedicineClass mc = new MedicineClass();
        string _patient_id;
        string _medicine_id;
        string _medicine_name;
        string _medicine_description;
        bool input_patient_state;

        public DispensingFrm()
        {
            InitializeComponent();
        }

        public void loadRandomId()
        {
            dc.maxId();
            Random rnd = new Random();
            int number = rnd.Next(10000, 99999);
            string sum_ref_id = number + dc._maxid.ToString();
            textBoxRefNo.Text = "BSOUT" + sum_ref_id;
        }

        public void loadPatient()
        {
            pc.list();
            foreach (DataRow item in pc.dtable.Rows)
            {
                comboBoxPatient.Items.Add(item[1].ToString() + "|" + item[0].ToString());
            }
        }

        public void loadMedicine()
        {
            mc.list();
            foreach (DataRow item in mc.dtable.Rows)
            {
                comboBoxMedicine.Items.Add(item[1].ToString() + "|" + item[4].ToString());
            }
        }

        private void DispensingFrm_Load(object sender, EventArgs e)
        {
            comboBoxPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxPatient.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMedicine.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMedicine.AutoCompleteSource = AutoCompleteSource.ListItems;
            DasboardForm.p_Navigation.Enabled = false;
            DasboardForm.p_Content.Enabled = false;

            this.TopMost = true;

            loadMedicine();
            loadPatient();
            loadRandomId();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DasboardForm.p_Navigation.Enabled = true;
            DasboardForm.p_Content.Enabled = true;

            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxPatientStatus.Text))
            {
                input_patient_state = true;
                if (comboBoxPatientStatus.Text == "Inpatient")
                {
                    textBoxWardNum.Enabled = true;
                    textBoxBedNum.Enabled = true;
                }
                else
                {
                    textBoxWardNum.Enabled = false;
                    textBoxBedNum.Enabled = false;
                }
            }
            else
            {
                input_patient_state = false;
            }
        }

        private void comboBoxMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueStr = comboBoxMedicine.Text;
            var vals = valueStr.Split('|')[0];
            mc.selectMedicine(vals);
            _medicine_id = mc._medicineid;
            _medicine_name = mc.drug_name;
            _medicine_description = mc.description;
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxMedicine.Text))
            {
                if (!string.IsNullOrEmpty(textBoxQty.Text))
                {
                    bool valid = false;

                    ic.listSpecific(int.Parse(_medicine_id));
                    foreach (DataRow item in ic.dtable.Rows)
                    {
                        valid = true;
                        if (input_patient_state == true)
                        {
                            if (int.Parse(item[5].ToString()) >= int.Parse(textBoxQty.Text))
                            {
                                int i = dataGridView1.Rows.Add();
                                dataGridView1.Rows[i].Cells[0].Value = _medicine_id;
                                dataGridView1.Rows[i].Cells[1].Value = _medicine_name;
                                dataGridView1.Rows[i].Cells[2].Value = _medicine_description;
                                dataGridView1.Rows[i].Cells[3].Value = textBoxQty.Text;

                                comboBoxMedicine.Text = "";
                                textBoxQty.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Quantity is higher than total stocks! Please add quantity less than or equal to " + item[5] + " quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seletecting patient state is required! Please select patient state!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    if (valid == false)
                    {
                        MessageBox.Show("This item is has no stocks in! Please set this item in recieving before dispensing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Quantity is required! Please add quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Medicine is required! Please select medicine!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void createStockOut()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cc.con.Close();
                cc.con.Open();
                string query = ("INSERT INTO `inventories`(`transaction_out_id`, `medicine_id`, `qty_out`, `created_at`) VALUES ('" + dc.lastId + "','" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[3].Value + "', Now());");
                MySqlCommand cmd = new MySqlCommand(query, cc.con);
                cmd.ExecuteNonQuery();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                string columnName = dataGridView1.Columns[columnIndex].Name;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                if (columnName == "colDel")
                {
                    foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                    {
                        if (oneCell.Selected)
                            dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }
            }
            catch
            {

            }
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueStr = comboBoxPatient.Text;
            var vals = valueStr.Split('|')[1];
            pc.selectPatient(vals);
            _patient_id = pc._customerid;
            string dateYear = DateTime.Parse(pc.birthdate).ToString("yyyy");
            string yearNow = DateTime.Now.ToString("yyyy");
            int age = int.Parse(yearNow) - int.Parse(dateYear);
            if (age != 0)
            {
                textBoxAge.Text = age.ToString();
            }
            else
            {
                textBoxAge.Clear();
            }
            textBoxAddress.Text = pc.address;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (input_patient_state == true)
            {
                if (string.IsNullOrEmpty(_patient_id))
                {
                    MessageBox.Show("Patient is required! Please select patient.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dataGridView1.Rows.Count < 1)
                    {
                        MessageBox.Show("Medicine is required! Please select medicine, add qty and add to the list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dc.customer_id = int.Parse(_patient_id);
                        dc.refno = textBoxRefNo.Text;
                        dc.age = int.Parse(textBoxAge.Text);
                        dc.patient_state = comboBoxPatientStatus.Text;
                        dc.war_number = (string.IsNullOrEmpty(textBoxWardNum.Text)) ? null : textBoxWardNum.Text;
                        dc.bed_number = (string.IsNullOrEmpty(textBoxBedNum.Text)) ? null : textBoxBedNum.Text;
                        dc.refno = textBoxRefNo.Text;
                        dc.pharmacist_name = DasboardForm.lbl_pharmacist_name.Text;
                        dc.createTransactionOut();

                        if (string.IsNullOrEmpty(dc.lastId))
                        {
                            MessageBox.Show("Transaction not created!" + dc.message);
                        }
                        else
                        {
                            createStockOut();
                            MessageBox.Show("" + dc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DasboardForm.p_Navigation.Enabled = true;
                            DasboardForm.p_Content.Enabled = true;
                            DasboardForm.b_dispensing.PerformClick();
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seletecting patient state is required! Please select patient state!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}
