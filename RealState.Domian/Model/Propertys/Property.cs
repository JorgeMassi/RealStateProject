using RealState.Domian.Model.Financial;

using RealState.Domian.Model.Users;

namespace RealState.Domian.Model.Propertys
{
    public class Property
    {
        public Guid Id { get; set; }
        public Typology? Type { get; set; }
        public Address? Location { get; set; }
        public int YearBuilt { get; set; }
        public double TotalArea { get; set; }
        public Rooms? TypedOfRooms { get; set; }
        public int Floors { get; set; }
        public Bathrooms? Bathrooms { get; set; }
        public Garage? Garage { get; set; }
        public bool Elevator { get; set; }
        public string? EnergyRating { get; set; }
        public Condition? ConditionOfUse { get; set; }
        public string? Description { get; set; }
        //public List<string?> Features { get; set; }
        public TypeOfUser? User { get; set; }
        public Price? Price { get; set; }
    }
}
