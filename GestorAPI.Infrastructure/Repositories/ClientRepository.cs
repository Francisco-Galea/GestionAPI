using GestionAPI.Application.Interfaces.IRepository;
using GestionAPI.Domain.Entities;
using GestionAPI.Infrastructure.Data;

namespace GestionAPI.Infrastructure.Repositories
{
    public class ClientRepository : Repository<ClientEntity>, IClientRepository
    {
        private readonly GestionDbContext dbContext;

        public ClientRepository(GestionDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async override Task LogicalDeleteAsync(int classId)
        {
        }

    }
}
