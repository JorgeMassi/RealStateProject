
using RealState.Application.Interfaces.Properties;
using RealState.Domian.Model;
using RealState.Infrastruture.Interfaces.Repositories;

namespace RealState.Application.Services
{
    public class PropertyService : IPropertyService
    {
       private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public Task<Property> Create(PropertyDto property)
        {
            return _propertyRepository.Create(property);
        }

        public async Task<Property> Delete(Property property)
        {
            return _propertyRepository.Delete(property);
        }

        public Task<Property> Delete(Guid id)
        {
            return _propertyRepository.Delete(id);
        }

        public Task<IEnumerable<Property>> GetAll()
        {
            return _propertyRepository.GetAll();
        }

        public Task<Property> GetById(Guid id)
        {
            return _propertyRepository.GetById(id);
        }

        public async Task<Property> Update(Property property)
        {
            return _propertyRepository.Update(property);
        }
    }
}
