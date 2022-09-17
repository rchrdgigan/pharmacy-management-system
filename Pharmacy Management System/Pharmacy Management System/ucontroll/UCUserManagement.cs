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
    public partial class UCUserManagement : UserControl
    {
        ConnectionClass cc = new ConnectionClass();
        UserClass uc = new UserClass();
        string _id;

        public UCUserManagement()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            uc.list();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = uc.dtable;
        }

        public void clearText()
        {
            fnameTxtBox.Clear();
            cpnumTxtBox.Clear();
            addressTxtBox.Clear();
            unameTxtBox.Clear();
            passwordTxtBox.Clear();
            confirmationTxtBox.Clear();
            registerBtn.Visible = true;
            updateBtn.Visible = false;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (fnameTxtBox.Text == "" || cpnumTxtBox.Text == "" || addressTxtBox.Text == "" || unameTxtBox.Text == "" || passwordTxtBox.Text == "" || confirmationTxtBox.Text == "")
            {
                MessageBox.Show("Please fill-up all entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (passwordTxtBox.Text == confirmationTxtBox.Text)
                {
                    uc.fname = fnameTxtBox.Text;
                    uc.contact = cpnumTxtBox.Text;
                    uc.address = addressTxtBox.Text;
                    uc.username = unameTxtBox.Text;
                    uc.password = passwordTxtBox.Text;
                    bool IsExist = uc.IsUserExist();
                    if (IsExist == true)
                    {
                        MessageBox.Show("" + uc.message, "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        uc.create();
                        MessageBox.Show(""+ uc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearText();
                        loadData();
                    }

                }
                else
                {
                    MessageBox.Show("Password confirmation doesn't match!", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked != false)
            {
                passwordTxtBox.UseSystemPasswordChar = false;
                confirmationTxtBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTxtBox.UseSystemPasswordChar = true;
                confirmationTxtBox.UseSystemPasswordChar = true;
            }
        }

        private void cpnumTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsNumber(ch))
            {
                e.Handled = true;
            }
        }

        private void UCUserManagement_Load(object sender, EventArgs e)
        {
            loadData();
            clearText();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (fnameTxtBox.Text == "" || cpnumTxtBox.Text == "" || addressTxtBox.Text == "" || unameTxtBox.Text == "" || passwordTxtBox.Text == "" || confirmationTxtBox.Text == "")
            {
                MessageBox.Show("Please fill-up all entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (passwordTxtBox.Text == confirmationTxtBox.Text)
                {
                    uc.fname = fnameTxtBox.Text;
                    uc.contact = cpnumTxtBox.Text;
                    uc.address = addressTxtBox.Text;
                    uc.username = unameTxtBox.Text;
                    uc.password = passwordTxtBox.Text;
                    uc.update(int.Parse(_id));
                    MessageBox.Show("" + uc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearText();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Password confirmation doesn't match!", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                        uc.delete(int.Parse(data_id));
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
                    updateBtn.Visible = true;
                    registerBtn.Visible = false;
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow rows = this.dataGridView1.Rows[e.RowIndex];
                        _id = rows.Cells["id"].Value.ToString();
                        fnameTxtBox.Text = rows.Cells["name"].Value.ToString();
                        cpnumTxtBox.Text = rows.Cells["contact"].Value.ToString();
                        addressTxtBox.Text = rows.Cells["address"].Value.ToString();
                        unameTxtBox.Text = rows.Cells["uname"].Value.ToString();
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
