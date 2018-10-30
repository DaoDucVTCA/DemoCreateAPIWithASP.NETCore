using MySql.Data.MySqlClient;
using Persistence;

namespace DAL
{
    public class EmployeeDAL
    {
        private string query;
        private MySqlDataReader reader;

        public Employee GetEmployeeById(int empId)
        {
            query = @"SELECT emp_no, first_name, last_name 
                    FROM employees WHERE emp_no=" + empId + ";";

            DBHelper.OpenConnection();
            reader = DBHelper.ExecQuery(query);

            Employee emp = null;
            if(reader.Read())
            {
                emp = ReadEmployeeInfo(reader);
            }

            DBHelper.CloseConnection();

            return emp;
        }

        private Employee ReadEmployeeInfo(MySqlDataReader reader)
        {
            Employee emp = new Employee();
            emp.empId = reader.GetInt32("emp_no");
            emp.empFirstName = reader.GetString("first_name");
            emp.empLastName = reader.GetString("last_name");

            return emp;
        }
    }
}