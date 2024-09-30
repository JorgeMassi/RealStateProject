using RealState.Domian.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Interfaces.Userzz.Token
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
