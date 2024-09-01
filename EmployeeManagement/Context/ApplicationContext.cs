using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<DepartmentMaster> DepartmentMasters { get; set; }
        public DbSet<CompanyMaster> CompanyMasters { get; set; }
        public DbSet<DepartmentMappingMaster> DepartmentMappingMaster { get; set; }
        public DbSet<EmployeeMaster> EmployeeMasters { get; set; }
        //public DbSet<EmployeeMasterList> EmployeeMastersList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
