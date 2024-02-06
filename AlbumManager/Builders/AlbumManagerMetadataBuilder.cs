using AlbumsManager.Base;
using AlbumsManager.Configurations.Interfaces;

namespace AlbumsManager
{
    public interface IAlbumManagerMetadataBuilder<TItem>
    {
        IAlbumManagerEditorBuilder<TItem> AddEditor(Action<IEditorConfiguration> configuration);
    }
    internal sealed class AlbumManagerMetadataBuilder<TItem> : IAlbumManagerMetadataBuilder<TItem>
        where TItem : class
    {
        private readonly IConfiguration _configuration;
        private readonly IAlbumManagerCreator<TItem> _creator;
        public AlbumManagerMetadataBuilder(IConfiguration configuration, IAlbumManagerCreator<TItem> creator)
        {
            _configuration = configuration;
            _creator = creator;
        }

        public IAlbumManagerEditorBuilder<TItem> AddEditor(Action<IEditorConfiguration> configuration)
        {
            configuration(_configuration.EditorConfiguration);
            return new AlbumManagerEditorBuilder<TItem>(_configuration, _creator);
        }
    }
}
    