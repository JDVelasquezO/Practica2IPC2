using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class DepartamentLogic
    {
        DepartamentDataAccess departamentData = new DepartamentDataAccess();

        public List<String> getListDepartaments()
        {
            return departamentData.getListDepartaments();
        }
    }
}
