using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pharmacy_Management_System
{
    class TypeClass : ConnectionClass
    {
        public MySqlDataReader msdtr;
        public DataTable dtable { get; set; }
        public string type_name { get; set; }
        public string _id { get; set; }
        public long modifId { get; set; }
        public string message { get; set; }
        public Int32 count { get; set; }

        public void create()
        {
            try
            {
                con.Close();
                con.Open();
                string query = ("INSERT INTO `types`(`type_name`, `created_at`) VALUES (@type_name,Now());");
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@type_name", type_name);
                cmd.ExecuteNonQuery();
                modifId = cmd.LastInsertedId;
                message = "Type Successfully Added!";

            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }
        public void list()
        {
            string query = "";
            query = "SELECT * FROM types ORDER BY id DESC";
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
                    cmd.CommandText = "UPDATE `types` SET 	type_name=@type_name WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.AddWithValue("@type_name", type_name);
                    cmd.ExecuteNonQuery();
                    message = "Successfully updated type data!";
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
                    cmd.CommandText = "DELETE FROM types WHERE id=@id";
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
    }
}
