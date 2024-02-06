using AlbumsManager.Base;
using AlbumsManager.Configurations.Interfaces;

namespace AlbumsManager.Builders
{
    public interface IAlbumManagerCreatorBuilder<TItem>
    {
        IAlbumManagerVieverBuilder<TItem> AddViewer(Action<IViewerConfiguration> configuration);
    }

    internal sealed class AlbumManagerCreatorBuilder<TItem> : IAlbumManagerCreatorBuilder<TItem>
        where TItem : class
    {
        private readonly IConfiguration _congiguration;
        private readonly IAlbumManagerCreator<TItem> _creator;
        public AlbumManagerCreatorBuilder(IConfiguration congiguration,IAlbumManagerCreator<TItem> creator)
        {
            _congiguration = congiguration;
            _creator = creator;
        }

        public IAlbumManagerVieverBuilder<TItem> AddViewer(Action<IViewerConfiguration> configuration)
        {
            configuration(_congiguration.ViewerConfiguration);
            return new AlbumManagerVieverBuilder<TItem>(_congiguration, _creator);
        }
    }
}
