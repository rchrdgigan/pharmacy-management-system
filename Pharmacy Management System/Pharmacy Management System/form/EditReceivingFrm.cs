using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void EditReceivingFrm_Load(object sender, EventArgs e)
        {
            DasboardForm.p_Navigation.Enabled = false;
            DasboardForm.p_Content.Enabled = false;

            this.TopMost = true;

            loadSupplier();
            loadMedicine();
            loadText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DasboardForm.p_Navigation.Enabled = true;
            DasboardForm.p_Content.Enabled = true;

            this.Close();
        }
    }
}
