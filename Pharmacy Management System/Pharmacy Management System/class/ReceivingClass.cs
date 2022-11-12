using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pharmacy_Management_System
{
    class ReceivingClass : ConnectionClass
    {
        //public MySqlDataReader msdtr;
        public DataTable dtable { get; set; }
        public string refno { get; set; }
        public Int32 supplier_id { get; set; }
        public string _id { get; set; }
        public string lastId { get; set; }
        public string message { get; set; }
        public Int32 _maxid { get; set; }
        public Int32 count { get; set; }

        public void maxId()
        {
            try
            {
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT MAX(ID) FROM transaction_in";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    _maxid = Convert.ToInt32(cmd.ExecuteScalar());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void createTransactionIn()
        {
            try
            {
                con.Close();
                con.Open();
                string query = ("INSERT INTO `transaction_in`(`supplier_id`, `refno`, `created_at`) VALUES (@supplier_id,@refno,Now());");
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@supplier_id", supplier_id);
                cmd.Parameters.AddWithValue("@refno", refno);
                cmd.ExecuteNonQuery();
                lastId = cmd.LastInsertedId.ToString();
                message = "Trasaction Delivery Successfully Added!";

            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void list()
        {
            string query = "";
            query = "SELECT transaction_in.id, transaction_in.supplier_id, transaction_in.refno, transaction_in.created_at, suppliers.supplier_name FROM transaction_in INNER JOIN suppliers ON transaction_in.supplier_id = suppliers.id ORDER BY transaction_in.id DESC";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }
        public void listToday()
        {
            string query = "";
            query = "SELECT transaction_in.id, transaction_in.supplier_id, transaction_in.refno, transaction_in.created_at, suppliers.supplier_name FROM transaction_in INNER JOIN suppliers ON transaction_in.supplier_id = suppliers.id WHERE transaction_in.created_at LIKE '%" + DateTime.Now.ToString("yyyy-MM-dd") + "%' ORDER BY transaction_in.id DESC";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }

        public void delete(int id)
        {
            try
            {
                con.Close();
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM transaction_in WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void listMedicine(int id)
        {
            string query = "";
            query = "SELECT inventories.id, inventories.transaction_in_id, inventories.medicine_id, inventories.qty_in, medicines.drug_name, medicines.description FROM inventories INNER JOIN medicines ON inventories.medicine_id = medicines.id WHERE inventories.transaction_in_id='" + id + "' ORDER BY inventories.id DESC";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }

        public void delStockIn(int id)
        {
            try
            {
                con.Close();
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM inventories WHERE transaction_in_id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void countReceiving()
        {
            try
            {
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM transaction_in WHERE created_at LIKE '%" + DateTime.Now.ToString("yyyy-MM-dd") + "%'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

    }
}
