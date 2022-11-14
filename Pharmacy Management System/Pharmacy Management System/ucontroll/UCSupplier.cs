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
    public partial class UCSupplier : UserControl
    {
        ConnectionClass cc = new ConnectionClass();
        SupplierClass sc = new SupplierClass();
        string _id;

        public UCSupplier()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            sc.list();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = sc.dtable;
        }

        public void clearText()
        {
            textBoxName.Clear();
            textBoxContact.Clear();
            textBoxAddress.Clear();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxContact.Text == "" || textBoxAddress.Text == "")
            {
                MessageBox.Show("Please type name entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sc.supplier_name = textBoxName.Text;
                sc.supplier_contact = textBoxContact.Text;
                sc.supplier_address = textBoxAddress.Text;
                sc.create();
                MessageBox.Show("" + sc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
                loadData();
            }
        }

        private void UCSupplier_Load(object sender, EventArgs e)
        {
            loadData();
            clearText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxContact.Text == "" || textBoxAddress.Text == "")
            {
                MessageBox.Show("Please type name entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sc.supplier_name = textBoxName.Text;
                sc.supplier_contact = textBoxContact.Text;
                sc.supplier_address = textBoxAddress.Text;
                sc.update(int.Parse(_id));
                MessageBox.Show("" + sc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
                loadData();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            string columnName = dataGridView1.Columns[columnIndex].Name;
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string data_id = row.Cells["id"].Value.ToString();
                if (columnName == "colDel")
                {
                    DialogResult result = MessageBox.Show("Are you sure want to delete this data?\n\nWarring : This data will be deleted permanently and you cannot undo or restore data!", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        sc.delete(int.Parse(data_id));
                        MessageBox.Show("Data deleted successfully!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                        {
                            if (oneCell.Selected)
                                dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                        }
                    }
                }
                else if (columnName == "colEdit")
                {
                    btnUpdate.Visible = true;
                    btnSave.Visible = false;
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow rows = this.dataGridView1.Rows[e.RowIndex];
                        _id = rows.Cells["id"].Value.ToString();
                        textBoxName.Text = rows.Cells["supplier_name"].Value.ToString();
                        textBoxContact.Text = rows.Cells["supplier_contact"].Value.ToString();
                        textBoxAddress.Text = rows.Cells["supplier_address"].Value.ToString();
                    }
                }
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("supplier_name like '%" + textBox2.Text + "%'");
        }

        private void textBoxContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }
    }
}
