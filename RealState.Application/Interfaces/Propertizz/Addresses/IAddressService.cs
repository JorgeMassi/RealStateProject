using RealState.Application.Interfaces.Generics;
using RealState.Domian.Model.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Interfaces.Propertizz.Addresses
{
    public interface IAddressService : IService<Address, int>
    {
        Task<IEnumerable<Address>> GetAll();
        Task<Address> GetById(int id);
        Task<Address> Create(Address address);
        Task<Address> Update(Address address);
        Task<Address> Delete(Address address);
        Task<Address> Delete(int id);
    }
}
