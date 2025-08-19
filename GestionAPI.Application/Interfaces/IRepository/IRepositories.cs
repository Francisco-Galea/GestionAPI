
namespace GestionAPI.Application.Interfaces.IRepository
{
    public interface IRepositories<T> where T : class
    {
        Task InsertAsync(T entity);
        Task<T?> GetByIdAsync(int classId);
        Task<List<T>> GetAllAsync();
        Task UpdateAsync(T entity);
        Task LogicalDeleteAsync(int classId);
    }
}
