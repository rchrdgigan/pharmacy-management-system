using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Pharmacy_Management_System
{
    class InventoryClass : ConnectionClass
    {
        public DataTable dtable { get; set; }

        public void list()
        {
            string query = "";
            query = "SELECT medicines.id, medicines.sku, medicines.drug_name, medicines.measurement, SUM(IFNULL(inventories.qty_in, 0)) as in_stock, SUM(IFNULL(inventories.qty_out, 0)) as out_stock, SUM(IFNULL(inventories.qty_in, 0)) - SUM(IFNULL(inventories.qty_out, 0)) as total_stocks FROM `medicines` INNER JOIN inventories ON inventories.medicine_id = medicines.id GROUP BY medicines.id, medicines.sku, medicines.drug_name, medicines.measurement";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }

        public void listSpecific(int id)
        {
            string query = "";
            query = "SELECT medicines.id, medicines.sku, medicines.drug_name, medicines.measurement, SUM(IFNULL(inventories.qty_in, 0)) as in_stock, SUM(IFNULL(inventories.qty_out, 0)) as out_stock, SUM(IFNULL(inventories.qty_in, 0)) - SUM(IFNULL(inventories.qty_out, 0)) as total_stocks FROM `medicines` INNER JOIN inventories ON inventories.medicine_id = medicines.id  WHERE medicines.id='" + id + "' GROUP BY medicines.id, medicines.sku, medicines.drug_name, medicines.measurement";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }

        public void create(int medid)
        {
            con.Close();
            con.Open();
            string query = ("INSERT INTO `inventories`(`medicine_id`,`created_at`) VALUES ('" + medid + "', Now());");
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
