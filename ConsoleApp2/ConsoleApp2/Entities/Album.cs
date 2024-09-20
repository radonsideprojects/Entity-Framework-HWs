namespace ConsoleApp2.Entities
{
    public class Album
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public Artist? AlbumArtist { get; set; }
        public int ArtistID { get; set; }
        public Genre? AlbumGenre { get; set; }
        public int GenreID { get; set; }
        public ICollection<Track> Tracks { get; set; }

    }
}
