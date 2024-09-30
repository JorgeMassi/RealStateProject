using RealState.Application.Interfaces.Generics;
using RealState.Domian.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Interfaces.Userzz.Users
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        public Task<User> GetByUsername(string username);
    }
}
