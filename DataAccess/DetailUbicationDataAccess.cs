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

        public bool AddDetailUbication(Detail_Ubication detailUbication)
        {
            bool response = false;
            conn.open();

            try
            {
                SqlCommand cmd = new SqlCommand("add_detail_location", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_address = new SqlParameter();
                p_address.ParameterName = "@address";
                p_address.SqlDbType = SqlDbType.VarChar;
                p_address.Size = 20;
                p_address.Value = detailUbication.address;

                SqlParameter p_municipality = new SqlParameter();
                p_municipality.ParameterName = "@municipality";
                p_municipality.SqlDbType = SqlDbType.VarChar;
                p_municipality.Size = 20;
                p_municipality.Value = detailUbication.municipality;

                SqlParameter p_departament = new SqlParameter();
                p_departament.ParameterName = "@departament";
                p_departament.SqlDbType = SqlDbType.VarChar;
                p_departament.Size = 20;
                p_departament.Value = detailUbication.departament;

                cmd.Parameters.Add(p_address);
                cmd.Parameters.Add(p_municipality);
                cmd.Parameters.Add(p_departament);

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

        public List<String> retunNames(String name)
        {
            conn.open();

            List<String> names = new List<String>();

            try
            {
                String nameObject = "";

                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand($"SELECT DISTINCT {name} FROM detail_location", conn.returnConn());
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
