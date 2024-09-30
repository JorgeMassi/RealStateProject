using RealState.Application.Dtos.LoginDto;
using RealState.Application.Interfaces.Generics;
using RealState.Application.Interfaces.Userzz.Accounts;
using RealState.Application.Interfaces.Userzz.DataProtection;
using RealState.Application.Interfaces.Userzz.Token;
using RealState.Application.Interfaces.Userzz.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Services.Userzz
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _repository;
        private readonly IDataProtectionService _dataProtectionService;
        private readonly ITokenService _tokenService;

        public AccountService(IUserRepository repository, IDataProtectionService dataProtectionService, ITokenService tokenService)
        {
            _repository = repository;
            _dataProtectionService = dataProtectionService;
            _tokenService = tokenService;
        }

        public async Task<string> Login(LoginRequestDto loginRequestDto)
        {
            var user = await _repository.GetByUsername(loginRequestDto.Username);

            if (user is null)
            {
                //_logger.LogInformation("User not found");
                throw new Exception($"User {loginRequestDto.Username} not found!");
            }

            var hashedPassword = _dataProtectionService.GetComputedHash(loginRequestDto.Password, user.Account.PasswordSaltHash);

            for (int i = 0; i < hashedPassword.Length; i++)
            {
                if (hashedPassword[i] != user.Account.PasswordHash[i])
                {
                    // _logger.LogInformation("Username / password does not match");
                    throw new Exception("Username or password incorrect!");
                }
            }

            return _tokenService.GenerateToken(user);
        }
    }
}
