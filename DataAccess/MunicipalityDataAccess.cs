using Presentation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MunicipalityDataAccess
    {
        Conn conn = new Conn();

        public List<String> getListMunicipality()
        {
            List<String> list = new List<String>();

            try
            {
                conn.open();
                String nameObject = "";

                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand($"SELECT name_municipality FROM municipality", conn.returnConn());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nameObject = reader["name_municipality"].ToString();
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
