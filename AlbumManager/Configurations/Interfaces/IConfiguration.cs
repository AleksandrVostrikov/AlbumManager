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
}
