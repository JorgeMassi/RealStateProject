using RealState.Application.Interfaces.Generics;
using RealState.Domian.Model.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Interfaces.Propertizz.Prices
{
    public interface IPriceService : IService<Price, int>
    {
        Task<IEnumerable<Price>> GetAll();
        Task<Price> GetById(int id);
        Task<Price> Create(Price price);
        Task<Price> Update(Price price);
        Task<Price> Delete(Price price);
        Task<Price> Delete(int id);
    }
}
