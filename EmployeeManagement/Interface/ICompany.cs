using EmployeeManagement.Models;

namespace EmployeeManagement.Interface
{
    public interface ICompany : IDisposable
    {
        List<CompanyMaster> List();
        CompanyMaster GetDetail(Guid id);

        string Add(CompanyMasterCreate cmp);
        string Edit(CompanyMasterCreate cmp);
        string Delete(Guid id);
    }
}
