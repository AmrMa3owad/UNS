using System.ComponentModel.DataAnnotations;

namespace Orion.Domain.Models.Common;

public interface IBaseUser<T>
{
    [Key]
    public T UserId { get; set; }
}