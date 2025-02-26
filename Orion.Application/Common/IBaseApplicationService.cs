namespace Orion.Application.Common
{
    public interface IBaseApplicationService<DTO, IType> where DTO : IBaseEntityDTO
    {
        Task<DTO> Create(DTO entity);
        Task<bool> Update(DTO entity, IType id);
        Task<bool> Delete(DTO entity);
        Task<DTO?> Get(
           IType id,
           CancellationToken cancellationToken,
           Guid? organizationId,
           bool include = false);
        Task<List<DTO>> GetAll(
            CancellationToken cancellationToken,
            Guid? organizationId,
            bool include = false);

    }
}
