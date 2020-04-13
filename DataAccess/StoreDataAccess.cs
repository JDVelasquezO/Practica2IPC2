using EntityLayer;
using Presentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StoreDataAccess
    {
        Conn conn = new Conn();

        public bool AddStores(Store store)
        {
            bool response = false;

            try
            {
                conn.open();

                SqlCommand cmd = new SqlCommand("add_store", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_idStore = new SqlParameter();
                p_idStore.ParameterName = "@idStore";
                p_idStore.SqlDbType = SqlDbType.Int;
                p_idStore.Value = store.id_store;

                SqlParameter p_phone = new SqlParameter();
                p_phone.ParameterName = "@phone";
                p_phone.SqlDbType = SqlDbType.VarChar;
                p_phone.Size = 10;
                p_phone.Value = store.phone;

                SqlParameter p_IdAddress = new SqlParameter();
                p_IdAddress.ParameterName = "@fkIdAddress";
                p_IdAddress.SqlDbType = SqlDbType.Int;
                p_IdAddress.Value = store.detail_ubication.id_detail_ubication;

                cmd.Parameters.Add(p_idStore);
                cmd.Parameters.Add(p_phone);
                cmd.Parameters.Add(p_IdAddress);

                cmd.ExecuteNonQuery();
                response = true;
                conn.close();
            }
            catch (Exception e)
            {
                throw;
            }

            return response;
        }

        public List<String> returnIdsStore()
        {
            conn.open();
            List<String> idsStore = new List<String>();

            try
            {
                String id = "";

                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand("SELECT id_store FROM store", conn.returnConn());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader["id_store"].ToString();
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
