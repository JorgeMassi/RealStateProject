using RealState.Application.Interfaces.Propertizz.Typologies;
using RealState.Application.Interfaces.UnitOfWork;
using RealState.Domian.Model.Properties;

namespace RealState.Application.Services.Propertizz
{
    public class TypologyService : ITypologyService
    {
        private readonly ITypologyRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public TypologyService(ITypologyRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Typology> Create(Typology typology)
        {
            //verify
            typology.Id = Convert.ToInt32(typology.Id);
            var entity = await _repository.Create(typology);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<Typology> Delete(Typology typology)
        {
            var entity = _repository.Delete(typology);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<Typology> Delete(int id)
        {
            var entity = await _repository.Delete(id);
            await _unitOfWork.Commit();
            return entity;
        }

        public Task<IEnumerable<Typology>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Typology> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public async Task<Typology> Update(Typology typology)
        {
            var entity = _repository.Update(typology);
            await _unitOfWork.Commit();
            return entity;
        }
    }

}
