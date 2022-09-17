using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Pharmacy_Management_System
{
    class UserClass : ConnectionClass
    {
        public MySqlDataReader msdtr;
        public DataTable dtable { get; set; }
        public string fname { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string _id { get; set; }
        public long modifId { get; set; }
        public string message { get; set; }
        public Int32 count { get; set; }

        public bool userVerification()
        {
            con.Open();

            bool check = false;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM users WHERE username=@uname AND password=@pass";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

                msdtr = cmd.ExecuteReader();

                while (msdtr.Read())
                {
                    _id = msdtr.GetString("id");
                    role = msdtr.GetString("role");
                    fname = msdtr.GetString("name");
                    check = true;
                }
                con.Close();
            }
            return check;
        }

        public bool IsUserExist()
        {
            con.Open();

            bool check = false;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM users WHERE username=@uname";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
                msdtr = cmd.ExecuteReader();

                while (msdtr.Read())
                {
                    message = "User Already Exist!";
                    check = true;
                }
                con.Close();
            }
            return check;
        }

        public void create()
        {
            try
            {
                con.Close();
                con.Open();
                string role = "admin";
                string query = ("INSERT INTO `users`(`name`, `contact`, `address`, `username`, `password`, `role`, `created_at`) VALUES (@fname,@contact,@address,@username,@password,@role,Now());");
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.ExecuteNonQuery();
                modifId = cmd.LastInsertedId;
                message = "User Successfully Registered";

            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void list()
        {
            string query = "";
            query = "SELECT * FROM users WHERE role='admin' ORDER BY id DESC";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }

        public void update(int id)
        {
            try
            {
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE `users` SET name=@fname, contact=@contact, address=@address, username=@username, password=@password WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    message = "Successfully updated user account data!";
                }
                con.Close();
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
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM users WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void countUser()
        {
            try
            {
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM users WHERE role='admin'";
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
