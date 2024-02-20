using AlbumsManager.Base;
using AlbumsManager.Base.Builders;
using AlbumsManager.Configurations.Interfaces;
using AlbumsManager.Models;

namespace AlbumsManager
{
    internal sealed class AlbumManagerMetadataBuilder<TItem> : IAlbumManagerMetadataBuilder<TItem>
        where TItem : ItemBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAlbumManagerCreator<TItem> _creator;
        public AlbumManagerMetadataBuilder(IConfiguration configuration, IAlbumManagerCreator<TItem> creator)
        {
            _configuration = configuration;
            _creator = creator;
        }

        public IAlbumManagerEditorBuilder<TItem> AddEditor<TEditorConfiguration>(Action<TEditorConfiguration> configuration)
        {
            configuration((TEditorConfiguration)_configuration.EditorConfiguration);
            return new AlbumManagerEditorBuilder<TItem>(_configuration, _creator);
        }
    }
}
    