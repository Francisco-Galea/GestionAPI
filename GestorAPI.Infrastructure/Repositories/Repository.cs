using GestionAPI.Application.Interfaces.IRepository;
using GestionAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GestionAPI.Infrastructure.Repositories
{
    public class Repository<T> : IRepositories<T> where T : class
    {

        private readonly GestionDbContext dbContext;
        private readonly DbSet<T> dbSet;

        public Repository(GestionDbContext dbContext)
        { 
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }

        public virtual async Task InsertAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            dbSet.Update(entity);
            await dbContext.SaveChangesAsync();
        }

        public virtual async Task<T?> GetByIdAsync(int classId)
        {
            return await dbSet.FindAsync(classId);
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task LogicalDeleteAsync(int classId)
        {
            throw new NotImplementedException();
        }

    }
}
