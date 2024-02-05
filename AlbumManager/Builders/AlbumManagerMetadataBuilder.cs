using AlbumsManager.Base;

namespace AlbumsManager
{
    public interface IAlbumManagerMetadataBuilder
    {
        IAlbumManagerEditorBuilder AddEditor<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration);
    }
    internal sealed class AlbumManagerMetadataBuilder : IAlbumManagerMetadataBuilder
    {
        private readonly IAlbumManagerCreator _creator;
        public AlbumManagerMetadataBuilder(IAlbumManagerCreator creator) => _creator = creator;
       
        public IAlbumManagerEditorBuilder AddEditor<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
        {
            return new AlbumManagerEditorBuilder(_creator);
        }
    }
}
    