namespace AlbumsManager.Models
{
    public class AlbumDirectory
    {
        public string? Description { get; set; }

        public string? DirectotyName { get; set; }

        public IEnumerable<AlbumItem>? Items { get; set; }
    }
}
