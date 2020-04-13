using DataAccess;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class DetailLocationLogic
    {
        DetailUbicationDataAccess detailUbicationAccess = new DetailUbicationDataAccess();

        public bool AddDetailUbication(Detail_Ubication detailUbication)
        {
            return detailUbicationAccess.AddDetailUbication(detailUbication);
        }

        public int getIdMunicipality(string name)
        {
            return detailUbicationAccess.getIdMunicipality(name);
        }
    }
}
