using RealState.Application.Interfaces.Generics;
using RealState.Domian.Model.Properties;

namespace RealState.Application.Interfaces.Propertizz.Properties
{
    public interface IPropertyRepository : IRepository<Property, Guid>
    {
    }
}
