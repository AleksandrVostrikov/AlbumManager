using AlbumsManager.Models;

namespace AlbumsManager.Base.Builders
{
    public interface IAlbumManagerMetadataBuilder<TItem>
        where TItem : ItemBase
    {
        IAlbumManagerEditorBuilder<TItem> AddEditor<TEditorConfiguration>(Action<TEditorConfiguration> configuration);
    }
}
