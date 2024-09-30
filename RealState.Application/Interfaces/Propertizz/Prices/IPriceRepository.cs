using RealState.Application.Interfaces.Generics;
using RealState.Domian.Model.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Interfaces.Propertizz.Prices
{
    public interface IPriceRepository : IRepository<Price, int>
    {
    }
}
