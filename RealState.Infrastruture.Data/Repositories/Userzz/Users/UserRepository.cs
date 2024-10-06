using Microsoft.EntityFrameworkCore;
using RealState.Application.Interfaces.Generics;
using RealState.Application.Interfaces.Userzz.Users;
using RealState.Domian.Model.Users;
using RealState.Infrastruture.Data.Repositories.Generics;

namespace RealState.Infrastruture.Data.Repositories.Userzz.Users
{
    public class UserRepository : Repository<User, Guid>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

        public async Task<User?> GetByUsername(string username)
        {
            return DbSet
                .Include(x => x.Account)
                .FirstOrDefault(x => x.Account.Username == username);
        }
    }
}
