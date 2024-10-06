using Microsoft.EntityFrameworkCore;
using RealState.Application.Interfaces.Propertizz.Addresses;
using RealState.Domian.Model.Properties;
using RealState.Infrastruture.Data.Repositories.Generics;

namespace RealState.Infrastruture.Data.Repositories.Propertiezz.Addresses
{
    public class AddressRepository : Repository<Address, int>, IAddressRepository
    {
        public AddressRepository(DbContext context) : base(context)
        {
        }
    }
}
