using RealState.Domian.Model.Financial;
using RealState.Domian.Model.User;

namespace RealState.Domian.Model.Propertys
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
        public int NumberOfParking { get; set; }
        public bool Elevator { get; set; }
        public string? EnergyRating { get; set; }
        public Condition? ConditionOfUse { get; set; }
        public string? Description { get; set; }
        public string? Features { get; set; }
        public TypeOfuser? User { get; set; }
        public Price? Price { get; set; }
    }
}
