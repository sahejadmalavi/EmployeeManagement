using EmployeeManagement.Models;

namespace EmployeeManagement.Interface
{
    public interface IEmployee : IDisposable
    {
        List<EmployeeMaster> GetList();
        EmployeeMaster Details(Guid id);
        string Create(EmployeeMaster emp);
        string Edit(EmployeeMaster emp);
        string Delete(EmployeeDeleteMaster emp);
    }
}
