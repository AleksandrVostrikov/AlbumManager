using AlbumsManager.Base;

namespace AlbumsManager.Builders
{
    public interface IAlbumManagerVieverBuilder
    {
        IAlbumManagerMetadataBuilder AddMetadataReader<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration);
    }

    internal class AlbumManagerVieverBuilder : IAlbumManagerVieverBuilder
    {
        private readonly ICreator _creator;
        public AlbumManagerVieverBuilder(ICreator creator) => _creator = creator;

        public IAlbumManagerMetadataBuilder AddMetadataReader<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
        {
            return new AlbumManagerMetadataBuilder(_creator);
        }
    }
}
