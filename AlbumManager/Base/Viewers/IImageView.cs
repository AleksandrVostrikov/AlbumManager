using AlbumsManager.Models;

namespace AlbumsManager.Base.Viewers
{
    public interface IImageView<out TItem>
    {
        public IEnumerable<TItem> Items { get; }
    }
}