using Microsoft.EntityFrameworkCore;
using RealState.Application.Interfaces.Propertizz.Addresses;
using RealState.Application.Interfaces.Typologies;
using RealState.Domian.Model.Properties;
using RealState.Infrastruture.Data.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Infrastruture.Data.Repositories.Addresses
{
    public class AddressRepository : Repository<Address, int>, IAddressRepository
    {
        public AddressRepository(DbContext context) : base(context)
        {
        }
    }
}
