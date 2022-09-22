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
    public partial class UCCategory : UserControl
    {
        ConnectionClass cc = new ConnectionClass();
        CategoryClass cat = new CategoryClass();
        string _id;

        public UCCategory()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            cat.list();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = cat.dtable;
        }

        public void clearText()
        {
            textBoxCatName.Clear();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxCatName.Text == "")
            {
                MessageBox.Show("Please category name entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cat.cat_name = textBoxCatName.Text;
                cat.create();
                MessageBox.Show("" + cat.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
                loadData();
            }
        }

        private void UCCategory_Load(object sender, EventArgs e)
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
            if (textBoxCatName.Text == "")
            {
                MessageBox.Show("Please category name entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cat.cat_name = textBoxCatName.Text;
                cat.update(int.Parse(_id));
                MessageBox.Show("" + cat.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    DialogResult result = MessageBox.Show("Are you sure want to delete this data?\n\nWarring : This data will be deleted permanently and affect the medicine data if connected in this category and you cannot undo or restore data!", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        cat.delete(int.Parse(data_id));
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
                        textBoxCatName.Text = rows.Cells["cat_name"].Value.ToString();
                    }
                }
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("cat_name like '%" + textBox2.Text + "%'");
        }
    }
}
