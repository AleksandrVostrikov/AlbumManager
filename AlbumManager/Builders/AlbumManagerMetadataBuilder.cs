using AlbumsManager.Base;

namespace AlbumsManager
{
    public interface IAlbumManagerMetadataBuilder
    {
        IAlbumManagerEditorBuilder AddEditor<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration);
    }
    internal class AlbumManagerMetadataBuilder : IAlbumManagerMetadataBuilder
    {
        private readonly ICreator _creator;
        public AlbumManagerMetadataBuilder(ICreator creator) => _creator = creator;
       
        public IAlbumManagerEditorBuilder AddEditor<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
        {
            return new AlbumManagerEditorBuilder(_creator);
        }
    }
}
    