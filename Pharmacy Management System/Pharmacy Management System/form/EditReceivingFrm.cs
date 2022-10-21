using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Pharmacy_Management_System.form
{
    public partial class EditReceivingFrm : Form
    {
        ConnectionClass cc = new ConnectionClass();
        SupplierClass sc = new SupplierClass();
        ReceivingClass rc = new ReceivingClass();
        MedicineClass mc = new MedicineClass();
        string _supplier_id;
        string _medicine_id;
        string _medicine_name;
        string _medicine_description;

        public EditReceivingFrm()
        {
            InitializeComponent();
        }
        public string _trans_id { get; set; }
        public string refno { get; set; }
        public string supplier_id { get; set; }
        public string supplier_name { get; set; }

        public void loadSupplier()
        {
            sc.list();
            foreach (DataRow item in sc.dtable.Rows)
            {
                comboBoxSupplier.Items.Add(item[1].ToString());
            }
        }

        public void loadMedicine()
        {
            mc.list();
            foreach (DataRow item in mc.dtable.Rows)
            {
                comboBoxMedicine.Items.Add(item[4].ToString() + "|" + item[1].ToString());
            }
        }

        public void loadText()
        {
            comboBoxSupplier.Text = supplier_name;
            _supplier_id = supplier_id;
            textBoxRefNo.Text = refno;
        }

        public void loadMedicineTransac()
        {
            rc.listMedicine(int.Parse(_trans_id));
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();
            foreach (DataRow item in rc.dtable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[2];
                dataGridView1.Rows[n].Cells[1].Value = item[4];
                dataGridView1.Rows[n].Cells[2].Value = item[5];
                dataGridView1.Rows[n].Cells[3].Value = item[3];
            }
        }

        private void EditReceivingFrm_Load(object sender, EventArgs e)
        {
            DasboardForm.p_Navigation.Enabled = false;
            DasboardForm.p_Content.Enabled = false;

            this.TopMost = true;

            loadSupplier();
            loadMedicine();
            loadMedicineTransac();
            loadText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DasboardForm.p_Navigation.Enabled = true;
            DasboardForm.p_Content.Enabled = true;

            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            string columnName = dataGridView1.Columns[columnIndex].Name;
            try
            {
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

        public void createStockIn()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cc.con.Close();
                cc.con.Open();
                string query = ("INSERT INTO `in_stocks`(`transaction_in_id`, `medicine_id`, `qty`, `created_at`) VALUES ('" + _trans_id + "','" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[3].Value + "', Now());");
                MySqlCommand cmd = new MySqlCommand(query, cc.con);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Generic name is required! Please select generic name data and add qty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                rc.delStockIn(int.Parse(_trans_id));
                createStockIn();
                MessageBox.Show("Successfully Updated!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DasboardForm.p_Navigation.Enabled = true;
                DasboardForm.p_Content.Enabled = true;
                DasboardForm.b_receiving.PerformClick();
                this.Close();
            }
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxQty.Text))
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
                MessageBox.Show("Quantity is required! Please add quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
