using Microsoft.EntityFrameworkCore;
using RealState.Application.Interfaces.Properties;
using RealState.Domian.Model;
using RealState.Infrastruture.Data.Repositories.Generics;

namespace RealState.Infrastruture.Data.Repositories.Properties
{
    public class PropertyRepository : Repository<Property, Guid>, IPropertyRepository
    {
        public PropertyRepository(DbContext context) : base(context)
        {
        }
    }
}
