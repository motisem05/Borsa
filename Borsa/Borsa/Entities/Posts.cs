namespace Borsa.Entities
{
    public class Posts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public DateTime? LastModified { get; set; }

    }
}
