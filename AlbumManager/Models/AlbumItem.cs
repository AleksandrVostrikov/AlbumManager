namespace AlbumsManager.Models
{

    public class AlbumItem
    {
        public string FileName { get; set; } = null!;

        public string? Description { get; set; }

        public long FileSize { get; set; }
    }
}
