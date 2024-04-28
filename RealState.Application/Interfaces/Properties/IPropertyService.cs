using RealState.Application.Dto;
using RealState.Application.Interfaces.Generics;
using RealState.Domian.Model;

namespace RealState.Application.Interfaces.Properties
{
    public interface IPropertyService :IService <PropertyDto, Guid>
    {
        Task<IEnumerable<PropertyDto>> GetAll();
        Task<PropertyDto> GetById(Guid id);
        Task<PropertyDto> Create(PropertyDto porperty);
        Task<PropertyDto> Update(PropertyDto porperty);
        Task<PropertyDto> Delete(PropertyDto porperty);
        Task<PropertyDto> Delete(Guid id);
    }
}
