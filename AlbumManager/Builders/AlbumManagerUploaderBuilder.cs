using AlbumsManager.Base;

namespace AlbumsManager
{
    public interface IAlbumManagerUploaderBuilder
    {
        public AlbumManager Build();
    }

    internal sealed class AlbumManagerUploaderBuilder : IAlbumManagerUploaderBuilder
    {
        private readonly IAlbumManagerCreator _creator;

        public AlbumManagerUploaderBuilder(IAlbumManagerCreator creator) => _creator = creator;
       
        public AlbumManager Build()
        {
            var items = _creator.GetItems();
            var manager = new AlbumManager(items);
            return manager;
        }
    }
}
    