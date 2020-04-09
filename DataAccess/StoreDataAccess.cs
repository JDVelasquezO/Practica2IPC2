using Presentation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StoreDataAccess
    {
        Conn conn = new Conn();

        public List<Int32> returnIdsStore()
        {
            conn.open();
            List<Int32> idsStore = new List<Int32>();

            try
            {
                int id;

                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand("SELECT id_store FROM store", conn.returnConn());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id_store"].ToString());
                    idsStore.Add(id);
                }
                
                conn.close();
            }
            catch (Exception)
            {

                throw;
            }

            return idsStore;
        }
    }
}
