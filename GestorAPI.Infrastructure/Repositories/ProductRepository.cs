using GestionAPI.Application.Interfaces.IRepository;
using GestionAPI.Domain.Entities;
using GestionAPI.Infrastructure.Data;

namespace GestionAPI.Infrastructure.Repositories
{
    public class ProductRepository : Repository<ProductEntity>, IProductRepository
    {
        private readonly GestionDbContext dbContext;

        public ProductRepository(GestionDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async override Task LogicalDeleteAsync(int classId)
        {
        }

    }
}
