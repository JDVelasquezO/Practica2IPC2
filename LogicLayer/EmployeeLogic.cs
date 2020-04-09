﻿using DataAccess;
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

        public List<Employee> getEmployeesByDepartament(String name)
        {
            return employeeData.getEmployeesByDepartament(name);
        }

        public List<Employee> getEmployeesByMunicipality(String name)
        {
            return employeeData.getEmployeesByMunicipality(name);
        }
    }
}
