using AlbumsManager.Models;

namespace AlbumsManager.Base.Builders
{
    public interface IAlbumManagerUploaderBuilder<TItem>
        where TItem : ItemBase
    {
        public Task<AlbumManager<TItem>> BuildAsync();
    }
}
