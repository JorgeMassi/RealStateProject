using RealState.Application.Interfaces.Generics;
using RealState.Domian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Interfaces.Typologies
{
    public interface ITypologyService : IService<Typology, int>
    {
        Task<IEnumerable<Typology>> GetAll();
        Task<Typology> GetById(int id);
        Task<Typology> Create(Typology typology);
        Task<Typology> Update(Typology typology);
        Task<Typology> Delete(Typology typology);
        Task<Typology> Delete(int id);
    }
}
