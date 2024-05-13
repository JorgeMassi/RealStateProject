using RealState.Domian.Model.Propertys;

namespace RealState.Domian.Model.Users
{
    public class Favourites
    {
        public int Id { get; set; }
        public Property? Propertys { get; set; }
        public User? User { get; set; }
    }
}