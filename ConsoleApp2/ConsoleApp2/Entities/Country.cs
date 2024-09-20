namespace ConsoleApp2.Entities
{
    public class Country
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public ICollection<Artist>? Artists { get; set;}
    }
}
