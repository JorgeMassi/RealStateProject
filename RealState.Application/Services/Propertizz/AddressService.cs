using RealState.Application.Interfaces.Properties;
using RealState.Application.Interfaces.Propertizz.Addresses;
using RealState.Application.Interfaces.UnitOfWork;
using RealState.Domian.Model.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Services.Propertizz
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public AddressService(IAddressRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Address> Create(Address address)
        {
            //verify
            address.Id = Convert.ToInt32(address.Id);
            var entity = await _repository.Create(address);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<Address> Delete(Address address)
        {
            var entity = _repository.Delete(address);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<Address> Delete(int id)
        {
            var entity = await _repository.Delete(id);
            await _unitOfWork.Commit();
            return entity;
        }

        public Task<IEnumerable<Address>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Address> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task<Address> Update(Address address)
        {
            var entity = _repository.Update(address);
            await _unitOfWork.Commit();
            return entity;
        }
    }
}
