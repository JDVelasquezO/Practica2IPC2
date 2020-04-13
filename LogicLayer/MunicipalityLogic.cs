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
            return municipalityData.AddMunicipality(municipality);
        }
    }
}
