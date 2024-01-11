using AlbumsManager.Base;
using AlbumsManager.Viewers;
using System.Text;

namespace AlbumsManager
{
    public sealed class AlbumManager
    {
        public List<AlbumItem> Items { get; }

        protected internal AlbumManager(IEnumerable<AlbumItem> items) => Items = items.ToList();
         
        public override string ToString()
        {
            var stringBuilder = new StringBuilder("Album manager configuration");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Total items: {Items.Count()}");
            
            return stringBuilder.ToString();
        }

        public IImageView GetView() => new DefaultImageView(Items);
    }
}
