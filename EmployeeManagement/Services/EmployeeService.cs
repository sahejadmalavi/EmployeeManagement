using EmployeeManagement.Context;
using EmployeeManagement.Interface;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Services
{
    public class EmployeeService : IEmployee
    {
        private bool disposedValue;
        private readonly ApplicationContext _EMP;
        public EmployeeService(ApplicationContext EMP)
        {
            _EMP = EMP;
        }

        public string Create(EmployeeMaster employee)
        {
            try
            {
                // Validation logic
                var departmentExists = _EMP.DepartmentMasters.Any(d => d.DPTId == employee.DPTId);
                if (!departmentExists)
                {
                    return "Department ID does not exist.";
                }

                // File handling
                if (employee.EMPImage == null)
                    return "File not selected";

                var base64Image = employee.EMPImage.Split(',')[1];
                byte[] bytes = Convert.FromBase64String(base64Image);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/Employee/");
                var dt = DateTime.Now.ToString("ddMMyyyyhhmmss");
                var logo = dt + ".png";
                
                System.IO.File.WriteAllBytes(path + logo, bytes);

                // Set additional properties
                employee.EMPIsActive = true;
                employee.EMPCreatedDate = DateTime.Now;
                employee.EMPUpdateDate = DateTime.Now;
                employee.EMPImage = logo;

                _EMP.EmployeeMasters.Add(employee);
                _EMP.SaveChanges();
                return "Success";
            }
            catch (Exception ex)
            {
                return "Error Occurred";
            }
        }

        public string Delete(EmployeeDeleteMaster emp)
        {
            try
            {
                var data = _EMP.EmployeeMasters.FirstOrDefault(a => a.EMPId == emp.EMPId);
                var file = Directory.GetCurrentDirectory() + "/wwwroot/Images/Employee/" + data.EMPImage;
                if (System.IO.File.Exists(file))
                {
                    System.IO.File.Delete(file);
                }
                _EMP.Remove(data);
                _EMP.SaveChanges();
                var massage = "Success";
                return massage;
            }
            catch(Exception ex)
            {
                return "Error Occurred";
            }
        }

        public EmployeeMaster Details(Guid id)
        {
            var emp = _EMP.EmployeeMasters.Include(p => p.department).FirstOrDefault(e => e.EMPId == id);
            return emp;
        }

        public string Edit(EmployeeMaster Employee)
        {
            try
            {
                var existingEmployee = _EMP.EmployeeMasters.FirstOrDefault(a => a.EMPId == Employee.EMPId);
                if (existingEmployee == null)
                {
                    return "Employee not found.";
                }

                var departmentExists = _EMP.DepartmentMasters.Any(d => d.DPTId == Employee.DPTId);
                if (!departmentExists)
                {
                    return "Department ID does not exist.";
                }

                var employee = _EMP.EmployeeMasters.FirstOrDefault(a => a.EMPId == Employee.EMPId);
                if (employee == null)
                {
                    var massage1 = "Position Null";
                    return massage1;
                }
                if (Employee.EMPImage != null && Employee.EMPImage!="")
                {
                    var base64Image = Employee.EMPImage.Split(',')[1];
                    byte[] bytes = Convert.FromBase64String(base64Image); // Convert  Base64Image
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/Employee/");
                    var dt = DateTime.Now.ToString("ddMMyyyyhhmmss");
                    var Logo = dt + ".png";
                    System.IO.File.WriteAllBytes(path + Logo, bytes);
                    employee.EMPImage = Logo;
                }


                employee.EMPFirstName = Employee.EMPFirstName;
                employee.EMPLastName = Employee.EMPLastName;
                employee.EMPDob = Employee.EMPDob;
                employee.EMPPhone = Employee.EMPPhone;
                employee.EMPGender = Employee.EMPGender;
                employee.EMPQualification = Employee.EMPQualification;
                employee.EMPCity = Employee.EMPCity;
                employee.EMPState = Employee.EMPState;
                employee.EMPPincode = Employee.EMPPincode;
                employee.EMPAddress = Employee.EMPAddress;
                employee.EMPEmail = Employee.EMPEmail;
                employee.DPTId = Employee.DPTId;
                employee.EMPJoiningDate = Employee.EMPJoiningDate;
                Employee.EMPUpdateDate = DateTime.Now;

                _EMP.SaveChanges();
                return "Success";

            }
            catch(Exception ex)
            {
                return "Error Occurred";
            }
        }

        public List<EmployeeMaster> GetList()
        {
            var emp = _EMP.EmployeeMasters.Include(p => p.department).ToList(); 
            return emp;
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
        // ~EmployeeService()
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
