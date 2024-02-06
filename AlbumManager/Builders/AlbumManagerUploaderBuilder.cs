using AlbumsManager.Base;
using AlbumsManager.Configurations.Interfaces;

namespace AlbumsManager
{
    public interface IAlbumManagerUploaderBuilder<TItem>
    {
        public AlbumManager<TItem> Build();
    }

    internal sealed class AlbumManagerUploaderBuilder<TItem> : IAlbumManagerUploaderBuilder<TItem>
        where TItem : class
    {
        private readonly IConfiguration _configuration;
        private readonly IAlbumManagerCreator<TItem> _creator;

        public AlbumManagerUploaderBuilder(IConfiguration configuration, IAlbumManagerCreator<TItem> creator)
        {
            _configuration = configuration;
            _creator = creator;
        }

        public AlbumManager<TItem> Build()
        {
            var items = _creator.GetItems();
            var manager = new AlbumManager<TItem>(items);
            return manager;
        }
    }
}
    