using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace Pharmacy_Management_System
{
    class ConnectionClass
    {
        public MySqlConnection con;

        public ConnectionClass()
        {
            string envLoc = Application.StartupPath + @"\env.txt";
            string[] env = File.ReadAllLines(envLoc);
            string ConnectionString = "datasource= '" + env[0] + "'; database='" + env[1] + "'; port= '" + env[2] + "'; username= '" + env[3] + "'; pwd = '" + env[4] + "'; SslMode =none;  convert zero datetime=True";
            con = new MySqlConnection(ConnectionString);
        }
    }
}
