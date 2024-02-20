using AlbumsManager.Models;

namespace AlbumsManager.Base.Builders
{
    public interface IAlbumManagerVieverBuilder<TItem>
        where TItem : ItemBase
    {
        IAlbumManagerMetadataBuilder<TItem> AddMetadataReader<TMetadataReaderConfiguration>(Action<TMetadataReaderConfiguration> configuration);
    }
}
