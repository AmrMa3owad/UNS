using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.Models.Common;

public class BaseEntity<IType> : IBaseEntity<IType>
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public IType Id { get; set; }
    public bool Deleted { get; set; }
}