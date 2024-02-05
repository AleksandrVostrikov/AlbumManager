using AlbumsManager.Creators.FolderAlbum;

namespace AlbumsManager.Extensions
{
    public static class AlbumManagerBuilderExtensions
    {
        public static AlbumManager AddDefaultFolder(this AlbumManagerBuilder<FolderAlbumManagerCreator> source, string folderPath)
        => new AlbumManagerBuilder<FolderAlbumManagerCreator>()
            .AddCreator<FolderAlbumCreatorConfiguration>(x => x.SourcePath = folderPath)
            .AddViewer<FolderAlbumViewerConfiguration>(x => x.TakeTop = 10)
            .AddMetadataReader<FolderAlbumMetadaReaderConfiguration>(x => x.Enabled = false)
            .AddEditor<FolderAlbumEditorConfiguration>(x => x.Enabled = false)
            .AddUploader<FolderAlbumUploaderConfiguration>(x => x.Enabled = false)
            .Build();

    }
}
