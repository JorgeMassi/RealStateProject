using RealState.Domian.Model.User;
using RealState.Domian.Model.Users;

namespace RealState.Domian.Model.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; } = false;
        public TypeOfuser UserTyped {  get; set; }
        public bool? IsBlocked { get; set; }
    }
}