using RealState.Application.Interfaces.Generics;
using RealState.Domian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Interfaces.Typologies
{
    public interface ITypologyRepository : IRepository<Typology, int >
    {
    }
}
