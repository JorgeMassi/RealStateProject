using RealState.Domian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Application.Dto
{
    public class PropertyDto
    {
        public class Property
        {
            public Guid Id { get; set; }
           
            public Address? Location { get; set; }
            
        }
    }
}
