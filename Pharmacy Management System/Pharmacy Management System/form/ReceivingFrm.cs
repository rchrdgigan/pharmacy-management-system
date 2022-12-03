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
    public partial class ReceivingFrm : Form
    {
        ConnectionClass cc = new ConnectionClass();
        SupplierClass sc = new SupplierClass();
        ReceivingClass rc = new ReceivingClass();
        MedicineClass mc = new MedicineClass();
        string _supplier_id;
        string _medicine_id;
        string _medicine_name;
        string _medicine_description;

        public ReceivingFrm()
        {
            InitializeComponent();
        }

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
                comboBoxMedicine.Items.Add(item[1].ToString() + "|" + item[4].ToString());
            }
        }

        public void loadRandomId()
        {
            rc.maxId();
            Random rnd = new Random();
            int number = rnd.Next(10000, 99999);
            string sum_ref_id = number + rc._maxid.ToString();
            textBoxRefNo.Text = "BSIN"+sum_ref_id;
        }

        private void ReceivingFrm_Load(object sender, EventArgs e)
        {
            TransitionAPI.AnimateWindow(this.Handle, 300, TransitionAPI.fadeIN);
            comboBoxMedicine.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMedicine.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            DasboardForm.p_Navigation.Enabled = false;
            DasboardForm.p_Content.Enabled = false;

            this.TopMost = true;

            loadSupplier();
            loadMedicine();
            loadRandomId();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DasboardForm.p_Navigation.Enabled = true;
            DasboardForm.p_Content.Enabled = true;

            this.Close();
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            sc.selectSupplier(comboBoxSupplier.Text);
            _supplier_id = sc._supplierid;
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
            else
            {
                MessageBox.Show("Medicine is required! Please select medicine!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void createStockIn()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cc.con.Close();
                cc.con.Open();
                string query = ("INSERT INTO `inventories`(`transaction_in_id`, `medicine_id`, `qty_in`, `created_at`) VALUES ('" + rc.lastId + "','" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[3].Value + "', Now());");
                MySqlCommand cmd = new MySqlCommand(query, cc.con);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_supplier_id))
            {
                MessageBox.Show("Please select default supplier in supplier entry!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("Medicine is required! Please select medicine data and add qty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else{
                    rc.supplier_id = int.Parse(_supplier_id);
                    rc.refno = textBoxRefNo.Text;
                    rc.createTransactionIn();

                    if (string.IsNullOrEmpty(rc.lastId))
                    {
                        MessageBox.Show("Transaction not created!");
                    }
                    else
                    {
                        createStockIn();
                        MessageBox.Show("" + rc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DasboardForm.p_Navigation.Enabled = true;
                        DasboardForm.p_Content.Enabled = true;
                        DasboardForm.b_receiving.PerformClick();
                        this.Close();
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
