using Microsoft.EntityFrameworkCore;
using RealState.Application.Interfaces.Prices;
using RealState.Application.Interfaces.Typologies;
using RealState.Domian.Model;
using RealState.Infrastruture.Data.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Infrastruture.Data.Repositories.Prices
{
    public class PriceRepository : Repository<Price, int>, IPriceRepository
    {
        public PriceRepository(DbContext context) : base(context)
        {
        }
    }
}
