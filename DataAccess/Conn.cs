using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Presentation
{
    public class Conn
    {
        string stringConn = "Data Source=localhost;Initial Catalog=practica2;Integrated Security=True";
        public SqlConnection conn = new SqlConnection();

        public Conn()
        {
            conn.ConnectionString = stringConn;
        }

        public void open()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void close()
        {
            conn.Close();
        }

        public SqlConnection returnConn()
        {
            return conn;
        }
    }
}
