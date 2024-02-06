using AlbumsManager.Base;
using AlbumsManager.Configurations.Interfaces;

namespace AlbumsManager
{
    public interface IAlbumManagerEditorBuilder<TItem>
    {
        IAlbumManagerUploaderBuilder<TItem> AddUploader(Action<IUploaderConfiguration> configuration);
    }
    internal sealed class AlbumManagerEditorBuilder<TItem> : IAlbumManagerEditorBuilder<TItem>
        where TItem : class
    {
        private readonly IConfiguration _configuration;
        private readonly IAlbumManagerCreator<TItem> _creator;

        public AlbumManagerEditorBuilder(IConfiguration configuration, IAlbumManagerCreator<TItem> creator)
        {
            _configuration = configuration;
            _creator = creator;
        }

        public IAlbumManagerUploaderBuilder<TItem> AddUploader(Action<IUploaderConfiguration> configuration)
        {
            configuration(_configuration.UploaderConfiguration);
            return new AlbumManagerUploaderBuilder<TItem>(_configuration, _creator);
        }
    }
}
    