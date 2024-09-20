namespace ConsoleApp2.Entities
{
    public class Playlist
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public Category PlaylistCategory { get; set; }
        public int CategoryID { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}
