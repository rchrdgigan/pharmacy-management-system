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
    public partial class UCDispensing : UserControl
    {
        DispensingClass dc = new DispensingClass();
        CustomerClass cc = new CustomerClass();

        public UCDispensing()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            dc.list();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dc.dtable;
        }

        private void loadDataToday()
        {
            dc.listToday();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dc.dtable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.DispensingFrm df = new form.DispensingFrm();
            df.Show();
        }

        private void UCDispensing_Load(object sender, EventArgs e)
        {
            if(UserControlHome.is_dispensing_click == true)
            {
                labelLoadStat.Text = "Today Data List";
                loadDataToday();
                UserControlHome.is_dispensing_click = false;
            }
            else
            {
                labelLoadStat.Text = "All Data List";
                loadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                string columnName = dataGridView1.Columns[columnIndex].Name;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string data_id = row.Cells["id"].Value.ToString();
                if (columnName == "colDel")
                {
                    DialogResult result = MessageBox.Show("Are you sure want to delete this data?\n\nWarring : This data will be deleted permanently and affect the stock-out data that connected in this transaction and you cannot undo or restore data!", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dc.delete(int.Parse(data_id));
                        MessageBox.Show("Data deleted successfully!"+ dc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        form.EditDispensingFrm ef = new form.EditDispensingFrm();

                        ef._trans_id = rows.Cells["id"].Value.ToString();
                        ef.patient_id = rows.Cells["patient_id"].Value.ToString();
                        cc.selectPatient(rows.Cells["patient_id"].Value.ToString());
                        ef.patient_name = cc.name;
                        ef.address = cc.address;
                        ef.birthdate = cc.birthdate;
                        ef.refno = rows.Cells["refno"].Value.ToString();
                        ef.patient_stat = rows.Cells["patient_status"].Value.ToString();
                        ef.ward_no = rows.Cells["ward_no"].Value.ToString();
                        ef.bed_no = rows.Cells["bed_no"].Value.ToString();
                        ef.Show();
                    }
                }
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("name like '%" + textBox1.Text + "%'");
        }
    }
}
