using AlbumsManager.Models;
using System.Runtime.CompilerServices;

namespace AlbumsManager.Base
{
    public interface IAlbumManagerCreator<TItem>
        where TItem : class
    {
        IEnumerable<TItem> GetItems();
    }
}
