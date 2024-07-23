namespace RealState.Domian.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; } = false;
        public enum TypeOfuser { Agent, Developer, Costumer }
        public bool? IsBlocked { get; set; }
    }
}