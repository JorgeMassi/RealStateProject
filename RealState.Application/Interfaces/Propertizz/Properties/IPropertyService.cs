using RealState.Application.Interfaces.Generics;
using RealState.Domian.Model.Properties;

namespace RealState.Application.Interfaces.Propertizz.Properties
{
    public interface IPropertyService : IService<Property, Guid>
    {
        Task<IEnumerable<Property>> GetAll();
        Task<Property> GetById(Guid id);
        Task<Property> Create(Property porperty);
        Task<Property> Update(Property porperty);
        Task<Property> Delete(Property porperty);
        Task<Property> Delete(Guid id);
    }
}
