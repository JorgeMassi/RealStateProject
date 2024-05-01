using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Interfaces.UnitOfWork
{
    public  interface UnitOfWork : IDisposable
    {
        Task<bool> commit();
    }
}
