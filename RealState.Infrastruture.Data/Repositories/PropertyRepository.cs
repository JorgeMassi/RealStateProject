using Microsoft.EntityFrameworkCore;
using RealState.Domian.Model;
using RealState.Infrastruture.Data.MSSQL.Generics;
using RealState.Infrastruture.Interfaces.Repositories;


namespace RealState.Infrastruture.Data.Repositories
{
    public class PropertyRepository : Repository<Property, Guid>, IPropertyRepository
    {
        public PropertyRepository(DbContext context) : base(context)
        {
        }
    }
}
