using RealState.Application.Dtos.LoginDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Interfaces.Userzz.Accounts
{
    public interface IAccountService
    {
        public Task<string> Login(LoginRequestDto loginRequestDto);
    }
}
