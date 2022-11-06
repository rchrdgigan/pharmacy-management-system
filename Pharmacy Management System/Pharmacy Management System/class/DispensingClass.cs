using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Pharmacy_Management_System
{
    class DispensingClass : ConnectionClass
    {
        //public MySqlDataReader msdtr;
        public DataTable dtable { get; set; }
        public string refno { get; set; }
        public Int32 customer_id { get; set; }
        public int age { get; set; }
        public string patient_state { get; set; }
        public string war_number { get; set; }
        public string bed_number { get; set; }
        public string pharmacist_name { get; set; }

        public string _id { get; set; }
        public string lastId { get; set; }
        public string message { get; set; }
        public Int32 _maxid { get; set; }

        public void maxId()
        {
            try
            {
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT MAX(ID) FROM transaction_out";
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

        public void createTransactionOut()
        {
            try
            {
                con.Close();
                con.Open();
                string query = ("INSERT INTO `transaction_out`(`patient_id`,`age`,`patient_state`,`war_number`,`bed_number`,`refno`,`pharmacist_name`,`created_at`) VALUES (@customer_id,@age,@patient_state,@war_number,@bed_number,@refno,@pharmacist_name,Now());");
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@customer_id", customer_id);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@patient_state", patient_state);
                cmd.Parameters.AddWithValue("@war_number", war_number);
                cmd.Parameters.AddWithValue("@bed_number", bed_number);
                cmd.Parameters.AddWithValue("@refno", refno);
                cmd.Parameters.AddWithValue("@pharmacist_name", pharmacist_name);
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
            query = "SELECT transaction_out.id, transaction_out.patient_id, transaction_out.refno, transaction_out.created_at, patients.name, patients.address FROM transaction_out INNER JOIN patients ON transaction_out.patient_id = patients.id ORDER BY transaction_out.id DESC";
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
                    cmd.CommandText = "DELETE FROM transaction_out WHERE id=@id";
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
