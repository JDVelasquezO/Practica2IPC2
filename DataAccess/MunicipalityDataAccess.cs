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

        public int getIdMunicipality(string name)
        {
            int id = 0;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("getIdMunicipality", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nameMunicipality = new SqlParameter();
                nameMunicipality.ParameterName = "@nameMunicipality";
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
            }
            catch (Exception)
            {
                throw;
            }

            return id;
        }

        public bool AddMunicipality(Municipality municipality)
        {
            bool response = false;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("add_municipality", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_IdDepartament = new SqlParameter();
                p_IdDepartament.ParameterName = "@fkIdDepartament";
                p_IdDepartament.SqlDbType = SqlDbType.VarChar;
                p_IdDepartament.Size = 20;
                p_IdDepartament.Value = municipality.departament.id_departament;

                SqlParameter p_nameMunicipality = new SqlParameter();
                p_nameMunicipality.ParameterName = "@nameDepartament";
                p_nameMunicipality.SqlDbType = SqlDbType.VarChar;
                p_nameMunicipality.Size = 20;
                p_nameMunicipality.Value = municipality.name_municipality;

                cmd.Parameters.Add(p_IdDepartament);
                cmd.Parameters.Add(p_nameMunicipality);

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
