using System.Reflection.PortableExecutable;

namespace RealState.Domian.Model.Users
{
    public class TypeOfUser
    {
        public int Guid { get; set; }
        public string? Name { get; set; } //{ Agent, Developer, Costumer, Guest, Admin }
        public bool? IsBlocked { get; set; }

    }
}