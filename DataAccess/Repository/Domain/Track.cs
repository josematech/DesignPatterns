namespace Domain.Models
{
    public class Track
    {
        public uint TrackId { get; set; }
        public string Name { get; set; }
        public uint? AlbumId { get; set; }
        public uint MediaTypeId { get; set; }
        public uint? GenreId { get; set; }
        public string? Composer { get; set; }
        public uint? Milliseconds { get; set; }
        public uint? Bytes { get; set; }
        public float UnitPrice { get; set; }
    }
}
