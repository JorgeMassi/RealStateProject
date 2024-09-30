using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Domian.Model.Users
{
    public record DataProtectionKeys(byte[] PasswordHash, byte[] PasswordSalt);
    
}
