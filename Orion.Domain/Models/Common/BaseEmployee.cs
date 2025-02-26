using System.ComponentModel.DataAnnotations;

namespace Orion.Domain.Models.Common
{
    public class BaseEmployee<IType> : IBaseEmployee<IType>
    {
        [Key]
        public IType EmployeeId { get; set; }
    }
}
