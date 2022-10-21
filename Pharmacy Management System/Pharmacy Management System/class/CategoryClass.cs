using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pharmacy_Management_System
{
    class CategoryClass : ConnectionClass
    {
        public MySqlDataReader msdtr;
        public DataTable dtable { get; set; }
        public string cat_name { get; set; }
        public string _id { get; set; }
        public string _catid { get; set; }
        public long modifId { get; set; }
        public string message { get; set; }
        public Int32 count { get; set; }

        public void create()
        {
            try
            {
                con.Close();
                con.Open();
                string query = ("INSERT INTO `categories`(`cat_name`, `created_at`) VALUES (@cat_name,Now());");
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cat_name", cat_name);
                cmd.ExecuteNonQuery();
                modifId = cmd.LastInsertedId;
                message = "Category Successfully Registered";

            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }
        public void list()
        {
            string query = "";
            query = "SELECT * FROM categories ORDER BY id DESC";
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
                    cmd.CommandText = "UPDATE `categories` SET 	cat_name=@cat_name WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.AddWithValue("@cat_name", cat_name);
                    cmd.ExecuteNonQuery();
                    message = "Successfully updated category data!";
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
                    cmd.CommandText = "DELETE FROM categories WHERE id=@id";
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

        public void selectCategory(string cat_name)
        {
            con.Open();
            string query = "";
            query = "SELECT * FROM categories WHERE cat_name='" + cat_name + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _catid = dr["id"].ToString();
            }
            con.Close();
        }

        public bool checkIfExist()
        {
            con.Close();
            con.Open();

            bool check = false;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM categories WHERE cat_name=@cat_name";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@cat_name", MySqlDbType.VarChar).Value = cat_name;

                msdtr = cmd.ExecuteReader();

                while (msdtr.Read())
                {
                    check = true;
                }
                con.Close();
            }
            return check;
        }
    }
}
