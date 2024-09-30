using RealState.Domian.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Interfaces.Userzz.DataProtection
{
    public interface IDataProtectionService
    {
        DataProtectionKeys Protect(string password);
        byte[] GetComputedHash(string password, byte[] salt);
    }
}
