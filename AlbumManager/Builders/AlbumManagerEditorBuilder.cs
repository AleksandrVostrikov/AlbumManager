using AlbumsManager.Base;
using AlbumsManager.Base.Builders;
using AlbumsManager.Configurations.Interfaces;
using AlbumsManager.Models;

namespace AlbumsManager
{
    internal sealed class AlbumManagerEditorBuilder<TItem> : IAlbumManagerEditorBuilder<TItem>
        where TItem : ItemBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAlbumManagerCreator<TItem> _creator;

        public AlbumManagerEditorBuilder(IConfiguration configuration, IAlbumManagerCreator<TItem> creator)
        {
            _configuration = configuration;
            _creator = creator;
        }

        public IAlbumManagerUploaderBuilder<TItem> AddUploader<TUploaderConfiguration>(Action<TUploaderConfiguration> configuration)
        {
            configuration((TUploaderConfiguration)_configuration.UploaderConfiguration);
            return new AlbumManagerUploaderBuilder<TItem>(_configuration, _creator);
        }
    }
}
    