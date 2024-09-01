using EmployeeManagement.Models;

namespace EmployeeManagement.Interface
{
    public interface IDepartment : IDisposable
    {
        List<DepartmentMaster> List();
        DepartmentMaster Details(Guid id);
        string Create(DepartmentMaster dpt);
        string Edit(DepartmentMaster dpt);
        string Delete(Guid guid);
        List<DepartmentMaster> ListByCompany(Guid cmpId);
    }
}
