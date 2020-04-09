using Presentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Auth
    {
        Conn conn = new Conn();

        public string login(string cui, string pass)
        {
            string query = "SELECT * FROM employee";
            SqlCommand cmd = new SqlCommand(query, conn.returnConn());
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.open();

            string msg = "";

            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (cui == reader[1].ToString() && pass == reader[2].ToString())
                    {
                        msg = "Muy bien";
                        break;
                    }
                    else
                    {
                        msg = "No hay registros";
                        break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.close();
            }

            return msg;
        }
    }
}
