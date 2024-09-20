namespace ConsoleApp2.Entities
{
    public class Genre
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public ICollection<Album> Albums { get;set; }
    }
}
