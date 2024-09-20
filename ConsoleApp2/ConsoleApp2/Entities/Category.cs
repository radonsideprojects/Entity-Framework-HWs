namespace ConsoleApp2.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
}
