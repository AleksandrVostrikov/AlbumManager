using AlbumsManager.Configurations.FolderAlbum;

namespace AlbumsManager.Configurations.Interfaces
{
    public interface IConfiguration
    {
        ICreatorConfiguration CreatorConfiguration { get; }

        IViewerConfiguration ViewerConfiguration { get; }

        IMetadataReaderConfiguration MetadataReaderConfiguration { get; }

        IEditorConfiguration EditorConfiguration { get; }

        IUploaderConfiguration UploaderConfiguration { get; }
    }

    public abstract class Configuration : IConfiguration
    {
        public virtual ICreatorConfiguration CreatorConfiguration { get; } = new CreatorConfiguration();

        public virtual IViewerConfiguration ViewerConfiguration { get; } = new ViewerConfiguration();

        public virtual IMetadataReaderConfiguration MetadataReaderConfiguration { get; } = new MetadaReaderConfiguration();

        public virtual IEditorConfiguration EditorConfiguration { get; } = new EditorConfiguration();

        public virtual IUploaderConfiguration UploaderConfiguration { get; } = new UploaderConfiguration();
    }
}
