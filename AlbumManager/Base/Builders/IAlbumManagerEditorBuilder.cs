using AlbumsManager.Models;

namespace AlbumsManager.Base.Builders
{
    public interface IAlbumManagerEditorBuilder<TItem>
        where TItem : ItemBase
    {
        IAlbumManagerUploaderBuilder<TItem> AddUploader<TUploaderConfiguration>(Action<TUploaderConfiguration> configuration);
    }
}
