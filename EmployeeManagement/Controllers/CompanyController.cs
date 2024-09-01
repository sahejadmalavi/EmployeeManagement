using EmployeeManagement.Context;
using EmployeeManagement.Interface;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly ApplicationContext _CMP;
        private readonly ICompany _company;
        public CompanyController(ApplicationContext CMP, ICompany company)
        {
            _CMP = CMP;
            _company = company;
        }
        [HttpGet]
        public IActionResult Index()
        {
           var data =  _company.List();
            return Json(data);
        }
        [HttpGet]
        public IActionResult GetDetail(Guid id)
        {
           var data = _company.GetDetail(id);
            return Json(data);
        }
        [HttpPost]
        public IActionResult Create(CompanyMasterCreate company)
        {
            var data = _company.Add(company);
            return Json(data);
        }
        [HttpPost]
        public IActionResult Edit(CompanyMasterCreate Company)
        {
           var data = _company.Edit(Company);
            return Json(data);
        }
        [HttpPost]
        public IActionResult Delete(CompanyDeleteMaster cmp)
        {
            var data = _company.Delete(cmp.CMPId);
            return Json(data);
        }
    }
}
