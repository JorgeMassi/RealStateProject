using RealState.Application.Interfaces.Generics;
using RealState.Domian.Model;

namespace RealState.Application.Interfaces.Properties
{
    public interface IPropertyRepository : IRepository<Property, Guid>
    {
    }
}
