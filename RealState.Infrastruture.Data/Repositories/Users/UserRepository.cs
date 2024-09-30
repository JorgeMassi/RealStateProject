using Microsoft.EntityFrameworkCore;
using RealState.Application.Interfaces.Userzz.Users;
using RealState.Domian.Model.Users;
using RealState.Infrastruture.Data.Repositories.Generics;

namespace RealState.Infrastruture.Data.Repositories.Users
{
    public class UserRepository : Repository<User, Guid>
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
