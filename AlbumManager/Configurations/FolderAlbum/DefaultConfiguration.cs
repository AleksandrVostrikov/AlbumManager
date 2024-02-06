using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Configurations.Interfaces;

public class DefaultConfiguration : IConfiguration
{
    public ICreatorConfiguration CreatorConfiguration { get; } = new CreatorConfiguration();

    public IViewerConfiguration ViewerConfiguration { get; } = new ViewerConfiguration();

    public IMetadataReaderConfiguration MetadataReaderConfiguration { get; } = new MetadaReaderConfiguration();

    public IEditorConfiguration EditorConfiguration { get; } = new EditorConfiguration();

    public IUploaderConfiguration UploaderConfiguration { get; } = new UploaderConfiguration();
}