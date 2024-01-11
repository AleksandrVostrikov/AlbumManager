namespace AlbumsManager.Base
{
    public interface ICreator
    {
        IEnumerable<AlbumItem> GetItems();
    }
}
