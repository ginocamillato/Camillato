using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Caciorgna.Datos
{
    public class Base
    {

        private static SqlConnection _conn;

        public static SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        const string constKey = "SQLExpressConnection";

        public static void OpenConnection()
        {
            string var = ConfigurationManager.ConnectionStrings[constKey].ConnectionString;
            Conn = new SqlConnection(var);
            Conn.Open();
        }

        public static void CloseConnection()
        {
            Conn.Close();
            Conn = null;
            
        }

    }
}
