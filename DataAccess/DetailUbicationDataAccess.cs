using Presentation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DetailUbicationDataAccess
    {
        Conn conn = new Conn();

        public List<String> retunNames(String name)
        {
            conn.open();

            List<String> names = new List<String>();

            try
            {
                String nameObject = "";

                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand("SELECT DISTINCT " + name + " FROM detail_location", conn.returnConn());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nameObject = reader[name].ToString();
                    names.Add(nameObject);
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return names;
        }

        public List<String> returnNameMunicipality()
        {
            return retunNames("municipality");
        }

        public List<String> returnNameDepartament()
        {
            return retunNames("departament");
        }
    }
}
