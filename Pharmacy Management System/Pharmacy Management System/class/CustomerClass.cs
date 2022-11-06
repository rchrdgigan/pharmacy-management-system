using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pharmacy_Management_System
{
    class CustomerClass : ConnectionClass
    {
        //public MySqlDataReader msdtr;
        public DataTable dtable { get; set; }
        public string name { get; set; }
        public string birthdate { get; set; }
        public string address { get; set; }
        public string _customerid { get; set; }
        public long modifId { get; set; }
        public string message { get; set; }
        public Int32 count { get; set; }

        public void create()
        {
            try
            {
                con.Close();
                con.Open();
                string query = ("INSERT INTO `patients`(`name`,`birthdate`,`address`,`created_at`) VALUES (@name,@birthdate,@address,Now());");
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.ExecuteNonQuery();
                modifId = cmd.LastInsertedId;
                message = "Customer Successfully Added!";

            }
            catch (Exception ex)
            {
                message = "error"+ ex.ToString();
            }
        }
        public void list()
        {
            string query = "";
            query = "SELECT * FROM patients ORDER BY id DESC";
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
                    cmd.CommandText = "UPDATE `patients` SET name=@name, birthdate=@birthdate, address=@address WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@birthdate", birthdate);
                    cmd.Parameters.AddWithValue("@address", address);
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
                    cmd.CommandText = "DELETE FROM patients WHERE id=@id";
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
        public void selectPatient(string id)
        {
            con.Open();
            string query = "";
            query = "SELECT * FROM patients WHERE id='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _customerid = dr["id"].ToString();
                birthdate = dr["birthdate"].ToString();
                address = dr["address"].ToString();
            }
            con.Close();
        }

    }
}
