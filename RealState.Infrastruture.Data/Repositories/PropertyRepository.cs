using Microsoft.EntityFrameworkCore;
using RealState.Domian.Model;
using RealState.Infrastruture.Data.Repositories.Generics;
using RealState.Infrastruture.Interfaces.Generics.Repositories;

namespace RealState.Infrastruture.Data.Repositories
{
    public class PropertyRepository : Repository<Property, Guid>, IPropertyRepository
    {
        public PropertyRepository(DbContext context) : base(context)
        {
        }
    }
}
