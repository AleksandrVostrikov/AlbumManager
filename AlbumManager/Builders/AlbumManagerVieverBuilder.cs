using AlbumsManager.Base;
using AlbumsManager.Configurations.Interfaces;

namespace AlbumsManager.Builders
{
    public interface IAlbumManagerVieverBuilder<TItem>
    {
        IAlbumManagerMetadataBuilder<TItem> AddMetadataReader(Action<IMetadataReaderConfiguration> configuration);
    }

    internal sealed class AlbumManagerVieverBuilder<TItem> : IAlbumManagerVieverBuilder<TItem>
        where TItem : class
    {
        private readonly IConfiguration _configuration;
        private readonly IAlbumManagerCreator<TItem> _creator;
        public AlbumManagerVieverBuilder(IConfiguration configuration,IAlbumManagerCreator<TItem> creator)
        {
            _configuration = configuration;
            _creator = creator;
        }

        public IAlbumManagerMetadataBuilder<TItem> AddMetadataReader(Action<IMetadataReaderConfiguration> configuration)
        {
            configuration(_configuration.MetadataReaderConfiguration);
            return new AlbumManagerMetadataBuilder<TItem>(_configuration, _creator);
        }
    }
}
