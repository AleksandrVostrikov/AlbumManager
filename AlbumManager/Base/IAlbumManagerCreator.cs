using AlbumsManager.Models;
using System.Runtime.CompilerServices;

namespace AlbumsManager.Base
{
    public interface IAlbumManagerCreator<TItem>
        where TItem : ItemBase
    {
        Task<IEnumerable<TItem>> GetItemsAsync();
    }
}
