using AlbumsManager.Base;
using AlbumsManager.Base.Builders;
using AlbumsManager.Configurations.Interfaces;
using AlbumsManager.Models;

namespace AlbumsManager
{

    internal sealed class AlbumManagerUploaderBuilder<TItem> : IAlbumManagerUploaderBuilder<TItem>
        where TItem : ItemBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAlbumManagerCreator<TItem> _creator;

        public AlbumManagerUploaderBuilder(IConfiguration configuration, IAlbumManagerCreator<TItem> creator)
        {
            _configuration = configuration;
            _creator = creator;
        }

        public async Task<AlbumManager<TItem>> BuildAsync()
        {
            var items = await _creator.GetItemsAsync();
            var manager = new AlbumManager<TItem>(items, _configuration);
            return manager;
        }
    }
}
    