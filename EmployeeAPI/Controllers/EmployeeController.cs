using BL;
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
            EmployeeBL empBL = new EmployeeBL();
            Employee emp = empBL.GetEmployeeById(10001);

            return Ok(emp);
        }
    }
}