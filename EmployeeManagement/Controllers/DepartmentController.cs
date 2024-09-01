using EmployeeManagement.Context;
using EmployeeManagement.Interface;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class DepartmentController : Controller
    {
        private readonly ApplicationContext _DPT;
        private readonly IDepartment _department;
        public DepartmentController(ApplicationContext DPT, IDepartment department)
        {
            _DPT = DPT;
            _department = department;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var dpt = _department.List();
            return Json(dpt);
        }

        [HttpGet]
        public IActionResult GetByCompany(Guid id)
        {
            var dpt = _department.ListByCompany(id);
            return Json(dpt);
        }
        [HttpGet]
        public IActionResult GetDetail(Guid id)
        {
            var dpt = _department.Details(id);
            return Json(dpt);
        }
        [HttpPost]
        public IActionResult Create(DepartmentMaster dp)
        {
            // Validation logic
            var data = _department.Create(dp);
            return Json(data);
        }
        [HttpPost]
        public IActionResult Edit(DepartmentMaster Department)
        {
            var massage = _department.Edit(Department);
            return Json(massage);
        }
        [HttpPost]
        public IActionResult Delete(DepartmentDeleteMaster dpt)
        {
           var massage = _department.Delete(dpt.DPTId);
            return Json(massage);
        }

    }
}
