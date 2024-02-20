using AlbumsManager.Base;
using AlbumsManager.Base.Builders;
using AlbumsManager.Configurations.Interfaces;
using AlbumsManager.Models;

namespace AlbumsManager.Builders
{
    internal sealed class AlbumManagerVieverBuilder<TItem> : IAlbumManagerVieverBuilder<TItem>
        where TItem : ItemBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAlbumManagerCreator<TItem> _creator;
        public AlbumManagerVieverBuilder(IConfiguration configuration,IAlbumManagerCreator<TItem> creator)
        {
            _configuration = configuration;
            _creator = creator;
        }

        public IAlbumManagerMetadataBuilder<TItem> AddMetadataReader<TMetadataReaderConfiguration>(Action<TMetadataReaderConfiguration> configuration)
        {
            configuration((TMetadataReaderConfiguration)_configuration.MetadataReaderConfiguration);
            return new AlbumManagerMetadataBuilder<TItem>(_configuration, _creator);
        }
    }
}
