namespace AlbumsManager.Base
{
    public interface IAlbumManagerCreator
    {
        IEnumerable<AlbumItem> GetItems();
    }
}
