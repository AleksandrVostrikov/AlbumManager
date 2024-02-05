using AlbumsManager.Base;

namespace AlbumsManager
{
    public interface IAlbumManagerEditorBuilder
    {
        IAlbumManagerUploaderBuilder AddUploader<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration);
    }
    internal sealed class AlbumManagerEditorBuilder : IAlbumManagerEditorBuilder
    {
        private readonly IAlbumManagerCreator _creator;

        public AlbumManagerEditorBuilder(IAlbumManagerCreator creator) => _creator = creator;
       
        public IAlbumManagerUploaderBuilder AddUploader<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
        {
            return new AlbumManagerUploaderBuilder(_creator);
        }
    }
}
    