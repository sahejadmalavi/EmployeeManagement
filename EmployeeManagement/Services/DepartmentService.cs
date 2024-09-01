using EmployeeManagement.Context;
using EmployeeManagement.Interface;
using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class DepartmentService : IDepartment
    {
        private bool disposedValue;
        private readonly ApplicationContext _DPT;
        public DepartmentService(ApplicationContext DPT)
        {
            _DPT = DPT;
        }

        public string Create(DepartmentMaster department)
        {
            try
            {
                department.DPTIsActive = true;
                department.DPTCreatedDate = DateTime.Now;
                department.DPTUpdatedDate = DateTime.Now;
                _DPT.Add(department);
                _DPT.SaveChanges();
                var massage = "Success";
                return massage;
            }
            catch(Exception ex)
            {
                return "Error Occurred";
            }
     
        }

        public string Delete(Guid guid)
        {
            try
            {
                var data = _DPT.DepartmentMasters.FirstOrDefault(a => a.DPTId == guid);
                _DPT.Remove(data);
                _DPT.SaveChanges();
                var massage = "Success";
                return massage;
            }
            catch(Exception ex)
            {
                return "Error Occurred";
            }
        }

        public DepartmentMaster Details(Guid id)
        {
            var dpt = _DPT.DepartmentMasters.FirstOrDefault(e => e.DPTId == id);
            return dpt;
        }

        public string Edit(DepartmentMaster dpt)
        {
            try
            {
                var department = _DPT.DepartmentMasters.FirstOrDefault(a => a.DPTId == dpt.DPTId);
                if (department == null)
                {
                    var massage1 = "Position Null";
                    return massage1;
                }
                department.DPTName = dpt.DPTName;
                department.DPTUpdatedDate = DateTime.Now;
                _DPT.SaveChanges();
                var massage = "Success";
                return massage;
            }
            catch(Exception ex)
            {
                return "Error Occurred";
            }
        }

        public List<DepartmentMaster> ListByCompany(Guid cmpId)
        {
            var response = new List<DepartmentMaster>();
            var data = _DPT.DepartmentMappingMaster.Where(t => t.CMPId == cmpId).ToList();
            foreach ( var item in data)
            {
                var dptData = _DPT.DepartmentMasters.Where(t => t.DPTId == item.DPTId).FirstOrDefault();
                if(dptData != null)
                {
                    response.Add(dptData);
                }

            }
            return response;
        }

        public List<DepartmentMaster> List()
        {
            var dpt = _DPT.DepartmentMasters.ToList();
            return dpt;
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
        // ~DepartmentService()
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
