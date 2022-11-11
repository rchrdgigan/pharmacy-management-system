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
    public partial class UCCustomer : UserControl
    {
        ConnectionClass cc = new ConnectionClass();
        CustomerClass sc = new CustomerClass();
        string _id;

        public UCCustomer()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            sc.list();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = sc.dtable;
        }

        private void loadDataToday()
        {
            sc.listToday();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = sc.dtable;
        }

        public void clearText()
        {
            labelAge.Visible = false;
            labelAgeVal.Visible = false;
            textBoxName.Clear();
            dateTimePickerBirthdate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            textBoxAddress.Clear();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxAddress.Text == "")
            {
                MessageBox.Show("Please type name entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string convert_dt = DateTime.Parse(dateTimePickerBirthdate.Text).ToString("yyyy-MM-dd");
                sc.name = textBoxName.Text;
                sc.birthdate = convert_dt;
                sc.address = textBoxAddress.Text;
                sc.create();
                MessageBox.Show("" + sc.message, "Status"+ sc.birthdate, MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
                loadData();
            }
        }

        private void UCCustomer_Load(object sender, EventArgs e)
        {
            if(UserControlHome.is_patient_click == true)
            {
                labelLoadStat.Text = "Today Data List";
                loadDataToday();
                clearText();
                UserControlHome.is_patient_click = false;
            }
            else
            {
                labelLoadStat.Text = "All Data List";
                loadData();
                clearText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxAddress.Text == "")
            {
                MessageBox.Show("Please type name entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string convert_dt = DateTime.Parse(dateTimePickerBirthdate.Text).ToString("yyyy-MM-dd");
                sc.name = textBoxName.Text;
                sc.birthdate = convert_dt;
                sc.address = textBoxAddress.Text;
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
                        textBoxName.Text = rows.Cells["name"].Value.ToString();
                        dateTimePickerBirthdate.Text = rows.Cells["birthdate"].Value.ToString();
                        textBoxAddress.Text = rows.Cells["address"].Value.ToString();

                        string dateYear = DateTime.Parse(dateTimePickerBirthdate.Text).ToString("yyyy");
                        string yearNow = DateTime.Now.ToString("yyyy");
                        int age = int.Parse(yearNow) - int.Parse(dateYear);

                        if (age != 0)
                        {
                            labelAge.Visible = true;
                            labelAgeVal.Visible = true;
                            labelAgeVal.Text = age.ToString();
                        }
                        else
                        {
                            labelAge.Visible = false;
                            labelAgeVal.Visible = false;
                        }
                    }
                }
            }
            catch
            {

            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("name like '%" + textBox2.Text + "%'");
        }
    }
}
