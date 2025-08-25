using GestionAPI.Application.Interfaces.IRepository;
using GestionAPI.Domain.Entities;
using GestionAPI.Infrastructure.Data;

namespace GestionAPI.Infrastructure.Repositories
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {

        private readonly GestionDbContext dbContext;

        public UserRepository(GestionDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
