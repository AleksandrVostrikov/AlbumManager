using AlbumsManager.Base;

namespace AlbumsManager.Builders
{
    public interface IAlbumManagerVieverBuilder
    {
        IAlbumManagerMetadataBuilder AddMetadataReader<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration);
    }

    internal sealed class AlbumManagerVieverBuilder : IAlbumManagerVieverBuilder
    {
        private readonly IAlbumManagerCreator _creator;
        public AlbumManagerVieverBuilder(IAlbumManagerCreator creator) => _creator = creator;

        public IAlbumManagerMetadataBuilder AddMetadataReader<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
        {
            return new AlbumManagerMetadataBuilder(_creator);
        }
    }
}
