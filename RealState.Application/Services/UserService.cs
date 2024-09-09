using RealState.Application.Interfaces.Typologies;
using RealState.Application.Interfaces.UnitOfWork;
using RealState.Application.Interfaces.Users;
using RealState.Domian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Services
{
    public class UserService : IUserService
    {
            private readonly IUserRepository _repository;
            private readonly IUnitOfWork _unitOfWork;

            public UserService(IUserRepository repository, IUnitOfWork unitOfWork)
            {
                _repository = repository;
                _unitOfWork = unitOfWork;
            }

            public async Task<User> Create(User user)
            {
                //verify
                user.Id = Guid.NewGuid();
                var entity = await _repository.Create(user);
                await _unitOfWork.Commit();
                return entity;
            }

            public async Task<User> Delete(User user)
            {
                var entity = _repository.Delete(user);
                await _unitOfWork.Commit();
                return entity;
            }

            public async Task<User> Delete(Guid id)
            {
                var entity = await _repository.Delete(id);
                await _unitOfWork.Commit();
                return entity;
            }

            public Task<IEnumerable<User>> GetAll()
            {
                return _repository.GetAll();
            }

            public Task<User> GetById(Guid id)
            {
                return _repository.GetById(id);
            }

            public async Task<User> Update(User user)
            {
                var entity = _repository.Update(user);
                await _unitOfWork.Commit();
                return entity;
            }
        }
}
