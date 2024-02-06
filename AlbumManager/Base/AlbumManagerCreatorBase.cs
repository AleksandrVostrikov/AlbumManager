using AlbumsManager.Models;

namespace AlbumsManager.Base
{
    public abstract class AlbumManagerCreatorBase<TConfiguration, TItem> : IAlbumManagerCreator<TItem>
        where TItem : class
    {
        public TConfiguration Config { get; }

        public AlbumManagerCreatorBase(TConfiguration config) => Config = config;

        public abstract IEnumerable<TItem> GetItems();
    }
}
