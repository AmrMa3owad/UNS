using System.ComponentModel.DataAnnotations;

namespace Orion.Domain.Models.Common;

public interface IBaseEmployee<T>
{
    [Key]
    public T EmployeeId { get; set; }
}