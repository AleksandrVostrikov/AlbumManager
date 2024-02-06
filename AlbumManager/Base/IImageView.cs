using AlbumsManager.Models;

namespace AlbumsManager
{
    public interface IImageView<TItem>
    {
        public IEnumerable<TItem> Items { get; }
    }
}