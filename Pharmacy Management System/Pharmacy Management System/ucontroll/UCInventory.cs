using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pharmacy_Management_System.ucontroll
{
    public partial class UCInventory : UserControl
    {
        ConnectionClass cc = new ConnectionClass();
        InventoryClass ic = new InventoryClass();
        public UCInventory()
        {
            InitializeComponent();
        }
        private void UCInventory_Load(object sender, EventArgs e)
        {
            ic.list();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ic.dtable;

            count_lbl.Text = dataGridView1.RowCount.ToString();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var value = dataGridView1.Rows[i].Cells[4].Value.ToString();
                if (int.Parse(value) == 0)
                {
                    dataGridView1.Rows[i].Cells["StockAvailable"].Style = new DataGridViewCellStyle { ForeColor = Color.White, BackColor = Color.Gray };
                }else if (int.Parse(value) >= 21 && int.Parse(value) <= 30)
                {
                    dataGridView1.Rows[i].Cells["StockAvailable"].Style = new DataGridViewCellStyle { ForeColor = Color.White, BackColor = Color.Red };
                }
                else if(int.Parse(value) >= 31 && int.Parse(value) <= 50)
                {
                    dataGridView1.Rows[i].Cells["StockAvailable"].Style = new DataGridViewCellStyle { ForeColor = Color.White, BackColor = Color.Orange };
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("drug_name like '%" + textBox1.Text + "%'");
        }
    }
}
