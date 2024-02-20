using AlbumsManager.Configurations.Interfaces;
using AlbumsManager.Models;

namespace AlbumsManager.Base
{
    public abstract class AlbumManagerCreatorBase<TConfiguration, TItem> : IAlbumManagerCreator<TItem>
        where TConfiguration : class, IConfiguration
        where TItem : ItemBase
    {
        public TConfiguration Config { get; }

        public AlbumManagerCreatorBase(TConfiguration config) => Config = config;

        public abstract Task<IEnumerable<TItem>> GetItemsAsync();
    }
}
