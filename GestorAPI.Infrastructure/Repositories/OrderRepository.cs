using GestionAPI.Application.Interfaces.IRepository;
using GestionAPI.Domain.Entities;
using GestionAPI.Infrastructure.Data;

namespace GestionAPI.Infrastructure.Repositories
{
    public class OrderRepository : Repository<OrderEntity>, IOrderRepository
    {
        private readonly GestionDbContext dbContext;

        public OrderRepository(GestionDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

    }
}
