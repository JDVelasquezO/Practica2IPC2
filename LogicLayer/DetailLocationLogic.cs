using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class DetailLocationLogic
    {
        DetailUbicationDataAccess detailUbication = new DetailUbicationDataAccess();

        public List<String> returnNameMunicipality()
        {
            return detailUbication.returnNameMunicipality();
        }

        public List<String> returnNameDepartament()
        {
            return detailUbication.returnNameDepartament();
        }
    }
}
