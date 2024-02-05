namespace AlbumsManager.Base
{
    public abstract class AlbumManagerCreatorBase<TConfiguration> : IAlbumManagerCreator
    {
        public TConfiguration Config { get; }

        public AlbumManagerCreatorBase(TConfiguration config) => Config = config;

        public abstract IEnumerable<AlbumItem> GetItems();
    }
}
