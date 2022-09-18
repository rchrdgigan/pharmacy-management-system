using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pharmacy_Management_System
{
    class MedicineClass : ConnectionClass
    {
        public MySqlDataReader msdtr;
        public DataTable dtable { get; set; }
        public string sku { get; set; }
        public Int32 category_id { get; set; }
        public Int32 type_id { get; set; }
        public string drug_name { get; set; }
        public string measurement { get; set; }
        public string description { get; set; }
        public bool prescription { get; set; }
        public string _id { get; set; }
        public long modifId { get; set; }
        public string message { get; set; }
        public Int32 _maxid { get; set; }

        public void create()
        {
            try
            {
                con.Close();
                con.Open();
                string query = ("INSERT INTO `medicines`(`sku`, `category_id`, `type_id`, `drug_name`, `measurement`, `description`, `prescription`, `created_at`) VALUES (@sku, @category_id, @type_id, @drug_name, @measurement, @description, @prescription, Now());");
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@sku", sku);
                cmd.Parameters.Add("@category_id", MySqlDbType.Int32).Value = category_id;
                cmd.Parameters.Add("@type_id", MySqlDbType.Int32).Value = type_id;
                cmd.Parameters.AddWithValue("@drug_name", drug_name);
                cmd.Parameters.AddWithValue("@measurement", measurement);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.Add("@prescription", MySqlDbType.Bit).Value = prescription;
                cmd.ExecuteNonQuery();
                modifId = cmd.LastInsertedId;
                message = "Medicine Successfully Added!";

            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }
        public void list()
        {
            string query = "";
            query = "SELECT medicines.id, medicines.sku,categories.cat_name,types.type_name,medicines.drug_name,medicines.measurement,medicines.description,medicines.prescription FROM medicines INNER JOIN categories ON medicines.category_id = categories.id INNER JOIN types ON medicines.type_id = types.id ORDER BY medicines.id DESC";
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
                    cmd.CommandText = "UPDATE `medicines` SET category_id=@category_id, type_id=@type_id, drug_name=@drug_name, measurement=@measurement, description=@description, prescription=@prescription WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.AddWithValue("@category_id", category_id);
                    cmd.Parameters.AddWithValue("@type_id", type_id);
                    cmd.Parameters.AddWithValue("@drug_name", drug_name);
                    cmd.Parameters.AddWithValue("@measurement", measurement);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@prescription", prescription);
                    cmd.ExecuteNonQuery();
                    message = "Successfully updated medicine data!";
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
                    cmd.CommandText = "DELETE FROM medicines WHERE id=@id";
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

        public void maxId()
        {
            try
            {
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT MAX(ID) FROM medicines";
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

    }
}
