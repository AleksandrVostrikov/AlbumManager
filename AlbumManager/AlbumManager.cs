using AlbumsManager.Base;
using AlbumsManager.Base.Viewers;
using AlbumsManager.Configurations.Interfaces;
using AlbumsManager.Models;
using System.Text;

namespace AlbumsManager
{
    public sealed class AlbumManager<TItem>
        where TItem : ItemBase
    {
        private readonly DefaultImageView<TItem> _view;
        public List<TItem> Items { get; }
        public IConfiguration Configuration { get; }

        protected internal AlbumManager(IEnumerable<TItem> items, IConfiguration configuration)
        {
            Items = items.ToList();
            Configuration = configuration;
            _view = new(items);
        }



        public override string ToString()
        {
            var stringBuilder = new StringBuilder("Album manager configuration");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Total items: {Items.Count()}");

            return stringBuilder.ToString();
        }

        public async Task<IEnumerable<TItem>> GetViewAsync()
        {
            var result = await _view
            .ProcessAsync(Configuration.ViewerConfiguration);
            return result.Items;
        }
    }
}
