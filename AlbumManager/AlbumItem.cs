namespace AlbumsManager
{
    public class AlbumItem
    {
        public string FileName { get; set; } = null!;

        public string? Description { get; set; }

        public long FileSize { get; set; }

        public string? DirectotyName { get; set; }

        public IEnumerable<AlbumItem>? Items { get; set; }
    }
}
