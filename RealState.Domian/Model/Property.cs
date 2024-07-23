namespace RealState.Domian.Model
{
    public class Property
    {
        public Guid Id { get; set; }
        public Typology? Type { get; set; }
        public Address? Location { get; set; }
        public int YearBuilt { get; set; }
        public double TotalArea { get; set; }
        public int Rooms { get; set; }
        public int Floors { get; set; }
        public int Bathrooms { get; set; }
        public bool Garage { get; set; }
        public string? EnergyRating { get; set; }
        public enum Condition { New, Used, Renovated }
        public string? Description { get; set; }
        public string? Features { get; set; }
        public User? User { get; set; }
        public Price? Price { get; set; }
    }
}
