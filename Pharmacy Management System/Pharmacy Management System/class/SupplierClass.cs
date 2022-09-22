using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pharmacy_Management_System
{
    class SupplierClass : ConnectionClass
    {
        public MySqlDataReader msdtr;
        public DataTable dtable { get; set; }
        public string supplier_name { get; set; }
        public string supplier_contact { get; set; }
        public string supplier_address { get; set; }
        public string _supplierid { get; set; }
        public long modifId { get; set; }
        public string message { get; set; }
        public Int32 count { get; set; }

        public void create()
        {
            try
            {
                con.Close();
                con.Open();
                string query = ("INSERT INTO `suppliers`(`supplier_name`,`supplier_contact`,`supplier_address`,`created_at`) VALUES (@supplier_name,@supplier_contact,@supplier_address,Now());");
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@supplier_name", supplier_name);
                cmd.Parameters.AddWithValue("@supplier_contact", supplier_contact);
                cmd.Parameters.AddWithValue("@supplier_address", supplier_address);
                cmd.ExecuteNonQuery();
                modifId = cmd.LastInsertedId;
                message = "Supplier Successfully Added!";

            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }
        public void list()
        {
            string query = "";
            query = "SELECT * FROM suppliers ORDER BY id DESC";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }

        public void update(int id)
        {
            try
            {
                con.Close();
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE `suppliers` SET supplier_name=@supplier_name, supplier_contact=@supplier_contact, supplier_address=@supplier_address WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.AddWithValue("@supplier_name", supplier_name);
                    cmd.Parameters.AddWithValue("@supplier_contact", supplier_contact);
                    cmd.Parameters.AddWithValue("@supplier_address", supplier_address);
                    cmd.ExecuteNonQuery();
                    message = "Successfully updated supplier data!";
                }
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void delete(int id)
        {
            try
            {
                con.Close();
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM suppliers WHERE id=@id";
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
        public void selectSupplier(string supplier_name)
        {
            con.Open();
            string query = "";
            query = "SELECT * FROM suppliers WHERE supplier_name='" + supplier_name + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _supplierid = dr["id"].ToString();
            }
            con.Close();
        }
    }
}
