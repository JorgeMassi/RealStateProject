using RealState.Domian.Model.Propertys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Domian.Model.Users
{
    public class AgentUser : User
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Property Property { get; set; }
        public string Description { get; set; }

    }
}
