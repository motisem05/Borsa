namespace Borsa.Entities
{
    public class Stocks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public float CurrentPrice { get; set; }
    }
}
