using EntityLayer;
using Presentation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DepartamentDataAccess
    {
        Conn conn = new Conn();

        public List<String> getListDepartaments()
        {
            List<String> list = new List<String>();

            try
            {
                conn.open();
                String nameObject = "";

                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand($"SELECT name_departament FROM departament", conn.returnConn());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nameObject = reader["name_departament"].ToString();
                    list.Add(nameObject);
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }
    }
}
