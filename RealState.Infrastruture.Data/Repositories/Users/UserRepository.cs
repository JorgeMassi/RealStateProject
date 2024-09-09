using Microsoft.EntityFrameworkCore;
using RealState.Application.Interfaces.Typologies;
using RealState.Application.Interfaces.Users;
using RealState.Domian.Model;
using RealState.Infrastruture.Data.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Infrastruture.Data.Repositories.Users
{
    public class UserRepository : Repository<User, Guid>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
