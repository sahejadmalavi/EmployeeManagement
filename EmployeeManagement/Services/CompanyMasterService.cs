using EmployeeManagement.Context;
using EmployeeManagement.Interface;
using EmployeeManagement.Models;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EmployeeManagement.Services
{
    public class CompanyMasterService : ICompany
    {
        private bool disposedValue;
        private readonly ApplicationContext _CMP;
        public CompanyMasterService(ApplicationContext CMP)
        {
            _CMP = CMP;
        }

        public string Add(CompanyMasterCreate cmp)
        {
            try
            {
                var company = new CompanyMaster();
                

                company.CMPName = cmp.CMPName;
                company.CMPIsActive = true;
                company.CMPCreatedDate = DateTime.Now;
                company.CMPUpdatedDate = DateTime.Now;
                _CMP.Add(company);
                _CMP.SaveChanges();
                var dpt = cmp.dptid.Split(",");
                foreach(var d in dpt)
                {
                    var cmpDept = new DepartmentMappingMaster();
                    cmpDept.CMPId = company.CMPId;
                    cmpDept.DPTId = new Guid(d);
                    _CMP.Add(cmpDept);
                    _CMP.SaveChanges();
                }
                var massage = "Success";
                return massage;
            }
            catch (Exception ex)
            {
                return "Error Occured";
            }
        }

        public string Delete(Guid id)
        {
            try
            {
                var data = _CMP.CompanyMasters.FirstOrDefault(a => a.CMPId == id);
                _CMP.Remove(data);
                _CMP.SaveChanges();
                var massage = "Success";
                return massage;
            }
            catch(Exception ex)
            {
                return "Error Occured";
            }
        }

        public string Edit(CompanyMasterCreate cmp)
        {
            try
            {
                var company = _CMP.CompanyMasters.FirstOrDefault(a => a.CMPId == cmp.CMPId);
                if (company == null)
                {
                    var massage1 = "Position Null";
                    return massage1;
                }
                company.CMPName = cmp.CMPName;
                company.CMPUpdatedDate = DateTime.Now;
                _CMP.SaveChanges();
                
                var dpt = cmp.dptid.Split(",");
                foreach (var d in dpt)
                {
                    var dptId = new Guid(d);
                    var isExist = _CMP.DepartmentMappingMaster.Where(t => t.CMPId == company.CMPId && t.DPTId == dptId).FirstOrDefault();
                   if(isExist == null)
                    {
                        var cmpDept = new DepartmentMappingMaster();
                        cmpDept.CMPId = company.CMPId;
                        cmpDept.DPTId = new Guid(d);
                        _CMP.Add(cmpDept);
                        _CMP.SaveChanges();
                    }
                }
                var massage = "Success";
                return massage;
            }
            catch(Exception e)
            {
                return "Error Occurred";
            }
           
        }

        public CompanyMaster GetDetail(Guid id)
        {
            var cmp = _CMP.CompanyMasters.FirstOrDefault(e => e.CMPId == id);
            return cmp;
        }

        public List<CompanyMaster> List()
        {
            var cmp = _CMP.CompanyMasters.ToList();
            return cmp;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~CompanyMasterService()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
