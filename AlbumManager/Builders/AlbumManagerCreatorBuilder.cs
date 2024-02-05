using AlbumsManager.Base;

namespace AlbumsManager.Builders
{
    public interface IAlbumManagerCreatorBuilder
    {
        IAlbumManagerVieverBuilder AddViewer<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration);
    }

    internal class AlbumManagerCreatorBuilder : IAlbumManagerCreatorBuilder
    {
        private readonly ICreator _creator;
        public AlbumManagerCreatorBuilder(ICreator creator) => _creator = creator;

        public IAlbumManagerVieverBuilder AddViewer<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
        {
            return new AlbumManagerVieverBuilder(_creator);
        }
    }
}
