using DataAccess;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class MunicipalityLogic
    {
        MunicipalityDataAccess municipalityData = new MunicipalityDataAccess();

        public List<String> getListMunicipality()
        {
            return municipalityData.getListMunicipality();
        }

        public int getIdMunicipality(string name)
        {
            return municipalityData.getIdMunicipality(name);
        }

        public bool AddMunicipality(Municipality municipality)
        {
            bool response = false;

            string name = municipalityData.getNameMunicipality(municipality.name_municipality);

            if (name == municipality.name_municipality)
            {
                return response;
            }
            else
            {
                return municipalityData.AddMunicipality(municipality);
            }

        }
    }
}
