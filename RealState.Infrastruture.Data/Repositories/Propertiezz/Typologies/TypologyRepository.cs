using Microsoft.EntityFrameworkCore;
using RealState.Application.Interfaces.Propertizz.Typologies;
using RealState.Domian.Model.Properties;
using RealState.Infrastruture.Data.Repositories.Generics;

namespace RealState.Infrastruture.Data.Repositories.Propertiezz.Typologies
{
    public class TypologyRepository : Repository<Typology, int>, ITypologyRepository
    {
        public TypologyRepository(DbContext context) : base(context)
        {
        }
    }
}
