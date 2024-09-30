using RealState.Application.Interfaces.Addresses;
using RealState.Application.Interfaces.Propertizz.Prices;
using RealState.Application.Interfaces.UnitOfWork;
using RealState.Domian.Model.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Services.Propertizz
{
    public class PriceService : IPriceService
    {
        private readonly IPriceRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public PriceService(IPriceRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Price> Create(Price price)
        {
            //verify
            price.Id = Convert.ToInt32(price.Id);
            var entity = await _repository.Create(price);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<Price> Delete(Price price)
        {
            var entity = _repository.Delete(price);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<Price> Delete(int id)
        {
            var entity = await _repository.Delete(id);
            await _unitOfWork.Commit();
            return entity;
        }

        public Task<IEnumerable<Price>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Price> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task<Price> Update(Price price)
        {
            var entity = _repository.Update(price);
            await _unitOfWork.Commit();
            return entity;
        }
    }
}
