using DataAccess;
using EntityLayer;
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

        public int getIdDepartament(string name)
        {
            return departamentData.getIdDepartament(name);
        }

        public bool AddDepartament(Departament departament)
        {
            return departamentData.AddDepartament(departament);
        }
    }
}
