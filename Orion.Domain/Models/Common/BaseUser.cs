using System.ComponentModel.DataAnnotations;

namespace Orion.Domain.Models.Common
{
    public class BaseUser<IType> : IBaseUser<IType>
    {
        [Key]
        public IType UserId { get; set; }
    }
}
