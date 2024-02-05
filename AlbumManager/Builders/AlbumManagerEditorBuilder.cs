using AlbumsManager.Base;

namespace AlbumsManager
{
    public interface IAlbumManagerEditorBuilder
    {
        IAlbumManagerUploaderBuilder AddUploader<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration);
    }
    internal class AlbumManagerEditorBuilder : IAlbumManagerEditorBuilder
    {
        private readonly ICreator _creator;

        public AlbumManagerEditorBuilder(ICreator creator) => _creator = creator;
       
        public IAlbumManagerUploaderBuilder AddUploader<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
        {
            return new AlbumManagerUploaderBuilder(_creator);
        }
    }
}
    