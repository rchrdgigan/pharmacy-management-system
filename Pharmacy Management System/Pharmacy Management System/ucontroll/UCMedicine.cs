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
    public partial class UCMedicine : UserControl
    {
        ConnectionClass cc = new ConnectionClass();
        TypeClass tc = new TypeClass();
        CategoryClass cat = new CategoryClass();
        MedicineClass mc = new MedicineClass();
        InventoryClass ic = new InventoryClass();
        string cat_id;
        string type_id;
        string _id;
        bool isRegister = false;

        public UCMedicine()
        {
            InitializeComponent();
        }

        public void loadCategory()
        {
            cat.list();
            foreach (DataRow item in cat.dtable.Rows)
            {
                comboBoxCat.Items.Add(item[1].ToString());
                comboBoxCat.AutoCompleteCustomSource.Add(item[1].ToString());
            }
        }

        public void loadData()
        {
            mc.list();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = mc.dtable;
        }

        public void clearText()
        {
            loadData();
            mc.maxId();
            Random rnd = new Random();
            int number = rnd.Next(1000, 9999);
            string sum_sku_id = number + mc._maxid.ToString();
            textBoxSKU.Text = sum_sku_id;

            comboBoxCat.Text = "";
            comboBoxType.Text = "";
            textBoxDrugName.Clear();
            textBoxMeasurement.Clear();
            richTextBoxDescription.Clear();
            checkBoxPrescription.Checked = false;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            isRegister = false;
        }

        public void loadType()
        {
            tc.list();
            foreach (DataRow item in tc.dtable.Rows)
            {
                comboBoxType.Items.Add(item[1].ToString());
                comboBoxType.AutoCompleteCustomSource.Add(item[1].ToString());
            }
        }

        private void UCMedicine_Load(object sender, EventArgs e)
        {
            comboBoxType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxType.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCat.AutoCompleteSource = AutoCompleteSource.ListItems;
            clearText();
            
            loadCategory();
            loadType();
            count_lbl.Text = dataGridView1.RowCount.ToString();
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cat.selectCategory(comboBoxCat.Text);
            cat_id = cat._catid;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tc.selectType(comboBoxType.Text);
            type_id = tc._typeid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSKU.Text) || !string.IsNullOrEmpty(comboBoxCat.Text) || !string.IsNullOrEmpty(comboBoxType.Text) || !string.IsNullOrEmpty(textBoxDrugName.Text) || !string.IsNullOrEmpty(textBoxMeasurement.Text) || !string.IsNullOrEmpty(richTextBoxDescription.Text))
            {
                mc.sku = textBoxSKU.Text;
                mc.category_id = int.Parse(cat_id);
                mc.type_id = int.Parse(type_id);
                mc.drug_name = textBoxDrugName.Text;
                mc.measurement = textBoxMeasurement.Text;
                mc.description = richTextBoxDescription.Text;
                if (checkBoxPrescription.Checked == true)
                {
                    mc.prescription = true;
                }
                else
                {
                    mc.prescription = false;
                }
                mc.create();
                ic.create(int.Parse(mc.modifId));
                MessageBox.Show("" + mc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
                loadData();
            }
            else
            {
                MessageBox.Show("Please fill-up all entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearText();
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
                        mc.delete(int.Parse(data_id));
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
                        textBoxSKU.Text = rows.Cells["sku"].Value.ToString();
                        comboBoxCat.Text = rows.Cells["cat_name"].Value.ToString();
                        comboBoxType.Text = rows.Cells["type_name"].Value.ToString();
                        textBoxDrugName.Text = rows.Cells["drug_name"].Value.ToString();
                        textBoxMeasurement.Text = rows.Cells["measurement"].Value.ToString();
                        richTextBoxDescription.Text = rows.Cells["description"].Value.ToString();
                        string prescription = rows.Cells["prescription"].Value.ToString();
                        if (prescription == "True")
                        {
                            checkBoxPrescription.Checked = true;
                        }
                        else
                        {
                            checkBoxPrescription.Checked = false;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSKU.Text) || !string.IsNullOrEmpty(comboBoxCat.Text) || !string.IsNullOrEmpty(comboBoxType.Text) || !string.IsNullOrEmpty(textBoxDrugName.Text) || !string.IsNullOrEmpty(textBoxMeasurement.Text) || !string.IsNullOrEmpty(richTextBoxDescription.Text))
            {
                mc.sku = textBoxSKU.Text;
                mc.category_id = int.Parse(cat_id);
                mc.type_id = int.Parse(type_id);
                mc.drug_name = textBoxDrugName.Text;
                mc.measurement = textBoxMeasurement.Text;
                mc.description = richTextBoxDescription.Text;
                if (checkBoxPrescription.Checked == true)
                {
                    mc.prescription = true;
                }
                else
                {
                    mc.prescription = false;
                }
                mc.update(int.Parse(_id));
                MessageBox.Show("" + mc.message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
                loadData();
            }
            else
            {
                MessageBox.Show("Please type name entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("drug_name like '%" + textBox2.Text + "%'");
        }

        private void textBoxSKU_TextChanged(object sender, EventArgs e)
        {
            string barCode = textBoxSKU.Text;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = brCode.Draw(barCode, 56);
            }
            catch (Exception)
            {

            }
        }
        private void btnSaveBarcode_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (textBoxSKU.Text == dataGridView1.Rows[i].Cells[2].Value.ToString())
                {
                    isRegister = true;
                }
                
            }
            if (isRegister == true)
            {
                if (pictureBox1.Image == null)
                    return;
                using (SaveFileDialog saveFD = new SaveFileDialog() { Filter = "PNG|*.png" })
                {
                    if (saveFD.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image.Save(saveFD.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("SKU not registered! Please registered before you save barcode!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
