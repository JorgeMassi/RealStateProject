
using RealState.Application.Dto;
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

        public async Task<PropertyDto> Create(PropertyDto propertyDto)
        {
            Property property = new Property();
            property.Id = propertyDto.Id;
            property.Location = propertyDto.Location;

            await  _propertyRepository.Create(property );

            return propertyDto;
        }

        public Task< PropertyDto> Delete(PropertyDto propertyDto)
        {
            Property property = new Property();
            property.Id = propertyDto.Id;
            property.Location = propertyDto.Location;

            _propertyRepository.Delete(property);

            return Delete(propertyDto);

        }

        public Task<PropertyDto> Delete(Guid id)
        {
            Property property = new Property();
            PropertyDto propertyDto = new PropertyDto();
            property.Id = propertyDto.Id;

            _propertyRepository.Delete(property);
            return Delete(propertyDto.Id);
        }

        public Task<IEnumerable<PropertyDto>> GetAll()
        {

            _propertyRepository.GetAll();

            return GetAll();
        }

        public Task<PropertyDto> GetById(Guid id)
        {
            Property property = new Property();
            PropertyDto propertyDto = new PropertyDto();
            property.Id = propertyDto.Id;

            _propertyRepository.GetById(property.Id);
           
            return GetById(propertyDto.Id);
        }

        public Task<PropertyDto> Update(PropertyDto propertyDto)
        {
            Property property = new Property();
            property.Id = propertyDto.Id;
            property.Location = propertyDto.Location;
            _propertyRepository.Update(property);

            return Update(propertyDto);

        }
    }
}
