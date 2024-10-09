namespace WebApi.Repositories.Interfaces
{
    public interface ITypeProductRepository
    {
        Task<Guid> GetIdProduct();
        Task<Guid> GetIdService();
    }
}
