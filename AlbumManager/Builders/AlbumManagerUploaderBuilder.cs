using AlbumsManager.Base;

namespace AlbumsManager
{
    public interface IAlbumManagerUploaderBuilder
    {
        public AlbumManager Build();
    }

    internal class AlbumManagerUploaderBuilder : IAlbumManagerUploaderBuilder
    {
        private readonly ICreator _creator;

        public AlbumManagerUploaderBuilder(ICreator creator) => _creator = creator;
       
        public AlbumManager Build()
        {
            var items = _creator.GetItems();
            var manager = new AlbumManager(items);
            return manager;
        }
    }
}
    