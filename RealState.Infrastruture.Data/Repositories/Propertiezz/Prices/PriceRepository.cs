using Microsoft.EntityFrameworkCore;
using RealState.Application.Interfaces.Propertizz.Prices;
using RealState.Domian.Model.Properties;
using RealState.Infrastruture.Data.Repositories.Generics;

namespace RealState.Infrastruture.Data.Repositories.Propertiezz.Prices
{
    public class PriceRepository : Repository<Price, int>, IPriceRepository
    {
        public PriceRepository(DbContext context) : base(context)
        {
        }
    }
}
