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
    public partial class UCReceiving : UserControl
    {
        ReceivingClass rc = new ReceivingClass();

        public UCReceiving()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            rc.list();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = rc.dtable;
        }
        private void loadDataToday()
        {
            rc.listToday();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = rc.dtable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.ReceivingFrm rf = new form.ReceivingFrm();
            rf.Show();
        }

        private void UCReceiving_Load(object sender, EventArgs e)
        {
            if(UserControlHome.is_receiving_click == true)
            {
                labelLoadStat.Text = "Today Data List";
                loadDataToday();
                UserControlHome.is_receiving_click = false;
            }
            else
            {
                labelLoadStat.Text = "All Data List";
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
                    DialogResult result = MessageBox.Show("Are you sure want to delete this data?\n\nWarring : This data will be deleted permanently and affect the stock-in data that connected in this transaction and you cannot undo or restore data!", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        rc.delete(int.Parse(data_id));
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
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow rows = this.dataGridView1.Rows[e.RowIndex];
                        form.EditReceivingFrm ef = new form.EditReceivingFrm();
                        ef._trans_id = rows.Cells["id"].Value.ToString();
                        ef.supplier_id = rows.Cells["supplier_id"].Value.ToString();
                        ef.supplier_name = rows.Cells["supplier_name"].Value.ToString();
                        ef.refno = rows.Cells["refno"].Value.ToString();
                        ef.Show();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
