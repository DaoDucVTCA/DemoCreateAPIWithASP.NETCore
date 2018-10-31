using DAL;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace EmployeeAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/employee")]
    public class EmployeeController: Controller
    {
        [HttpGet]

        public IActionResult GetEmployee()
        {
            EmployeeDAL empDAL = new EmployeeDAL();
            Employee emp = empDAL.GetEmployeeById(10001);

            return Ok(emp);
        }
    }
}