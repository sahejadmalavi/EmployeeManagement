using EmployeeManagement.Context;
using EmployeeManagement.Interface;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext _EMP;
        private readonly IEmployee _employee;
        public EmployeeController(ApplicationContext EMP, IEmployee employee)
        {
            _EMP = EMP;
            _employee = employee;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var emp = _employee.GetList();
            return Json(emp);
        }
        [HttpGet]
        public IActionResult GetDetail(Guid id)
        {
            var emp = _employee.Details(id);
            return Json(emp);
        }
        [HttpPost]
        public IActionResult Create(EmployeeMaster employee)
        {
            try
            {
                var data = _employee.Create(employee);
                return Json(data);  
            }
            
            catch (Exception ex)
            {
                // Log the exception and return a general error
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }
        [HttpPost]
        public IActionResult Edit(EmployeeMaster Employee)
        {
            var massage = _employee.Edit(Employee);
            return Json(massage);
        }
        [HttpPost]
        public IActionResult Delete(EmployeeDeleteMaster emp)
        {
           var data = _employee.Delete(emp);
            return Json(data);
        }

    }
}
