using AlbumsManager.Base;
using AlbumsManager.Creators.FolderTreeAlbum;
using System.Runtime.InteropServices;

namespace AlbumsManager
{
    public class AlbumManagerBuilder
    {
        private ICreator _creator = null!;
        public void AddCreator<TCreator, TConfiguration>(Action<TConfiguration> configuration)
            where TCreator: AlbumCreatorBase<TConfiguration>
            where TConfiguration: class, new()
        {
            var config = new TConfiguration();
            configuration(config);
            _creator = (AlbumCreatorBase<TConfiguration>)Activator.CreateInstance(typeof(TCreator), config)!;
        }

        public AlbumManager Build()
        {
            var items = _creator.GetItems();
            var manager = new AlbumManager(items);
            return manager;
        }
    }
}
