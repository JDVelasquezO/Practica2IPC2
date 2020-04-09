using DataAccess;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class EmployeeLogic
    {
        EmployeeDataAccess employeeData = new EmployeeDataAccess();

        public List<Employee> getEmployeesByStore(int id)
        {
            return employeeData.getEmployeesByStore(id);
        }
    }
}
