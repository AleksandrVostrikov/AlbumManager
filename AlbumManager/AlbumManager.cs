using AlbumsManager.Base;
using AlbumsManager.Models;
using AlbumsManager.Viewers;
using System.Text;

namespace AlbumsManager
{
    public sealed class AlbumManager<TItem>
    {
        public List<TItem> Items { get; }

        protected internal AlbumManager(IEnumerable<TItem> items) => Items = items.ToList();
         
        public override string ToString()
        {
            var stringBuilder = new StringBuilder("Album manager configuration");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Total items: {Items.Count()}");
            
            return stringBuilder.ToString();
        }

        public IImageView<TItem> GetView() => new DefaultImageView<TItem>(Items);
    }
}
