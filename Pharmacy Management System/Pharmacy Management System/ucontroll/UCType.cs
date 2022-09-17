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
    public partial class UCType : UserControl
    {
        ConnectionClass cc = new ConnectionClass();
        TypeClass tc = new TypeClass();
        string _id;

        public UCType()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            tc.list();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = tc.dtable;
        }

        public void clearText()
        {
            textBoxTypeName.Clear();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxTypeName.Text == "")
            {
                MessageBox.Show("Please type name entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tc.type_name = textBoxTypeName.Text;
                tc.create();
                MessageBox.Show("" + tc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
                loadData();
            }
        }

        private void UCType_Load(object sender, EventArgs e)
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
            if (textBoxTypeName.Text == "")
            {
                MessageBox.Show("Please type name entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tc.type_name = textBoxTypeName.Text;
                tc.update(int.Parse(_id));
                MessageBox.Show("" + tc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    DialogResult result = MessageBox.Show("Are you sure want to delete this data?\n\nWarring : This data will be deleted permanently and you can't undo this action!", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        tc.delete(int.Parse(data_id));
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
                        textBoxTypeName.Text = rows.Cells["type_name"].Value.ToString();
                    }
                }
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("type_name like '%" + textBox2.Text + "%'");
        }
    }
}
