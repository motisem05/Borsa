namespace Borsa.Entities
{
    public class StocksHistory
    {
        public int Id { get; set; }
        public int StouckId { get; set; }
        public DateTime Date { get; set; }
        public float Price{ get; set; }
    }
}
