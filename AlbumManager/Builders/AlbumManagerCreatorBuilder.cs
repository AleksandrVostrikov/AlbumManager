using AlbumsManager.Base;

namespace AlbumsManager.Builders
{
    public interface IAlbumManagerCreatorBuilder
    {
        IAlbumManagerVieverBuilder AddViewer<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration);
    }

    internal sealed class AlbumManagerCreatorBuilder : IAlbumManagerCreatorBuilder
    {
        private readonly IAlbumManagerCreator _creator;
        public AlbumManagerCreatorBuilder(IAlbumManagerCreator creator) => _creator = creator;

        public IAlbumManagerVieverBuilder AddViewer<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
        {
            return new AlbumManagerVieverBuilder(_creator);
        }
    }
}
