using AlbumsManager.Models;

namespace AlbumsManager.Viewers
{
    public class DefaultImageView<TItem> : IImageView<TItem>
    {
        public DefaultImageView(IEnumerable<TItem> items)
        {
            Items = items;
        }
        public IEnumerable<TItem> Items { get; }
    }
}
