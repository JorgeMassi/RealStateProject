using RealState.Domian.Model;
using RealState.Infrastruture.Interfaces.Generics;

namespace RealState.Infrastruture
{
    public interface IPropertyRepository : IRepository<Property, Guid>
    {
    }
}
