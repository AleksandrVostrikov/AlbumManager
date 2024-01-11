namespace AlbumsManager.Base
{
    public abstract class AlbumCreatorBase<TConfiguration> : ICreator
    {
        public TConfiguration Config { get; }

        public AlbumCreatorBase(TConfiguration config) => Config = config;

        public abstract IEnumerable<AlbumItem> GetItems();
    }
}
