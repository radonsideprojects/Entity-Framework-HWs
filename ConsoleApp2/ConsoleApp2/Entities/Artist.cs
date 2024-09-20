using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2.Entities
{
    public class Artist
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public Country? ArtistCountry { get; set; }
        public int? CountryID { get; set; }
        public ICollection<Album> Albums { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}
