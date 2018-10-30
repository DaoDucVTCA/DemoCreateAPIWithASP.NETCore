using System;
using DAL;
using Persistence;

namespace BL
{
    public class EmployeeBL
    {
        private EmployeeDAL empDAL;

        public EmployeeBL()
        {
            empDAL = new EmployeeDAL();
        }

        public Employee GetEmployeeById(int empId)
        {
            return empDAL.GetEmployeeById(empId);
        }
    }
}
