using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pharmacy_Management_System.form
{
    public partial class EditDispensingFrm : Form
    {
        ConnectionClass cc = new ConnectionClass();
        DispensingClass dc = new DispensingClass();
        CustomerClass pc = new CustomerClass();
        MedicineClass mc = new MedicineClass();
        string _patient_id;
        string _medicine_id;
        string _medicine_name;
        string _medicine_description;

        public string _trans_id { get; set; }
        public string refno { get; set; }
        public string patient_id { get; set; }
        public string patient_name { get; set; }


        public EditDispensingFrm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
