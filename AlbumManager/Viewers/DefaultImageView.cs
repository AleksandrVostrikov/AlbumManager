namespace AlbumsManager.Viewers
{
    public class DefaultImageView : IImageView
    {
        public DefaultImageView(IEnumerable<AlbumItem> items)
        {
            Items = items;
        }
        public IEnumerable<AlbumItem> Items { get; }
    }
}
