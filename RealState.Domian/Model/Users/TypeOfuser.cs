using System.Reflection.PortableExecutable;

namespace RealState.Domian.Model.User
{
    public class TypeOfuser
    {
        public int Guid { get; set; }
        public string? Name { get; set; } //{ Agent, Developer, Costumer, Guest, Admin }
    }
}