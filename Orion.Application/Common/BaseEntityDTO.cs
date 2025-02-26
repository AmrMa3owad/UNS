namespace Orion.Application.Common
{
    public class BaseEntityDTO<IType> : IBaseEntityDTO
    {
        public IType Id { get; set; }

    }
}
