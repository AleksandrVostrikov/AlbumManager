namespace AlbumsManager
{
    public interface IImageView
    {
        public IEnumerable<AlbumItem> Items { get; }
    }
}