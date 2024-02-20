using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Configurations.Interfaces;

namespace AlbumsManager.Base
{
    public abstract class ConfigurationBase : IConfiguration
    {
        public virtual ICreatorConfiguration CreatorConfiguration { get; } = new CreatorConfiguration();

        public virtual IViewerConfiguration ViewerConfiguration { get; } = new ViewerConfiguration();

        public virtual IMetadataReaderConfiguration MetadataReaderConfiguration { get; } = new MetadaReaderConfiguration();

        public virtual IEditorConfiguration EditorConfiguration { get; } = new EditorConfiguration();

        public virtual IUploaderConfiguration UploaderConfiguration { get; } = new UploaderConfiguration();
    }
}
