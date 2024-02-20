using AlbumsManager.Models;

namespace AlbumsManager.Base.Builders
{
    public interface IAlbumManagerCreatorBuilder<TItem>
        where TItem : ItemBase
    {
        IAlbumManagerVieverBuilder<TItem> AddViewer<TViewerConfiguration>(Action<TViewerConfiguration> configuration);
    }
}
