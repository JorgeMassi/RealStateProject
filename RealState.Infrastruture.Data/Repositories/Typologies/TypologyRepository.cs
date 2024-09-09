using Microsoft.EntityFrameworkCore;
using RealState.Application.Interfaces.Properties;
using RealState.Application.Interfaces.Typologies;
using RealState.Domian.Model;
using RealState.Infrastruture.Data.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Infrastruture.Data.Repositories.Typologies
{
    public class TypologyRepository : Repository<Typology, int>, ITypologyRepository
    {
        public TypologyRepository(DbContext context) : base(context)
        {
        }
    }
}
