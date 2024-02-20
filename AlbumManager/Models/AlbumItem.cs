namespace AlbumsManager.Models
{

    public class AlbumItem : ItemBase
    {
        public long FileSize { get; set; }

        public byte[] OriginalBytes { get; set; } = null!;

        public byte[]? ProcessedBytes { get; set; }
    }
}
