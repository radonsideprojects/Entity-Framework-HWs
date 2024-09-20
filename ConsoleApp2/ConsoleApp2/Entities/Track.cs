namespace ConsoleApp2.Entities
{
    public class Track
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int? Duration { get; set; }
        public Artist TrackArtist { get; set; }
        public int ArtistID { get; set; }
        public Album TrackAlbum { get; set; }
        public int AlbumID { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
        
    }
}
