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
    public class DetailUbicationDataAccess
    {
        Conn conn = new Conn();

        public int getIdMunicipality(string name)
        {
            int id = 0;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("getIdAddress", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nameMunicipality = new SqlParameter();
                nameMunicipality.ParameterName = "@nameAddress";
                nameMunicipality.SqlDbType = SqlDbType.VarChar;
                nameMunicipality.Size = 50;
                nameMunicipality.Value = name;

                cmd.Parameters.Add(nameMunicipality);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Identificador"]);
                    break;
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return id;
        }

        public bool AddDetailUbication(Detail_Ubication detailUbication)
        {
            bool response = false;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("add_detail_location", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_address = new SqlParameter();
                p_address.ParameterName = "@address";
                p_address.SqlDbType = SqlDbType.VarChar;
                p_address.Size = 20;
                p_address.Value = detailUbication.address;

                SqlParameter p_IdMunicipality = new SqlParameter();
                p_IdMunicipality.ParameterName = "@fkIdMunicipality";
                p_IdMunicipality.SqlDbType = SqlDbType.Int;
                p_IdMunicipality.Value = detailUbication.municipality.id_municipality;

                cmd.Parameters.Add(p_address);
                cmd.Parameters.Add(p_IdMunicipality);

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
    }
}
