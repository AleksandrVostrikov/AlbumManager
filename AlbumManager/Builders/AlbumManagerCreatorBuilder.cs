using AlbumsManager.Base;
using AlbumsManager.Base.Builders;
using AlbumsManager.Configurations.Interfaces;
using AlbumsManager.Models;

namespace AlbumsManager.Builders
{

    internal sealed class AlbumManagerCreatorBuilder<TItem> : IAlbumManagerCreatorBuilder<TItem>
        where TItem : ItemBase
    {
        private readonly IConfiguration _congiguration;
        private readonly IAlbumManagerCreator<TItem> _creator;
        public AlbumManagerCreatorBuilder(IConfiguration congiguration,IAlbumManagerCreator<TItem> creator)
        {
            _congiguration = congiguration;
            _creator = creator;
        }

        public IAlbumManagerVieverBuilder<TItem> AddViewer<TViewerConfiguration>(Action<TViewerConfiguration> configuration)
            
        {
            configuration((TViewerConfiguration)_congiguration.ViewerConfiguration);
            return new AlbumManagerVieverBuilder<TItem>(_congiguration, _creator);
        }
    }
}
