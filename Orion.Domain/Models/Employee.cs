using Orion.Domain.Models.Common;

namespace Orion.Domain.Models
{
    public class Employee : BaseUser<int>
    {     
        public string? EmployeeType { get; set; }
        public int? EmployeeSalary { get; set; }
        public string? EmployeeDateOfJoin { get; set; }
        public string? EmployeeStatus { get; set; }
        public string? EmployeeQualifications { get; set; }

        public virtual User User { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        public virtual OfficeWorker OfficeWorker { get; set; }
    }
}
