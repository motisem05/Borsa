namespace Borsa.Entities
{
    public class Videos
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Title { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }


    }
}
