using RealState.Domian.Model;
using RealState.Infrastruture.Interfaces.Generics;

namespace RealState.Infrastruture.Interfaces.Generics.Repositories
{
    public interface IPropertyRepository : IRepository<Property, Guid>
    {
    }
}
