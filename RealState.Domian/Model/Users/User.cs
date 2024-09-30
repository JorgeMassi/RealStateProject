namespace RealState.Domian.Model.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public enum TypeOfuser { Agent, Developer, Costumer }
        public Account? Account { get; set; }
        //public bool IsAdmin { get; set; } = false;
        //public bool? IsBlocked { get; set; }

    }
}