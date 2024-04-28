namespace RealState.Domian.Model
{
    public class Price
    {
        public int Id { get; set; }
        public string? Currency { get; set; }
        public double Value { get; set; }
        public enum TypeOfPrice { Total, MonthlyValue }
    }
}