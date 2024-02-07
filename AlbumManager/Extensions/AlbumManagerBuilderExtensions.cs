using AlbumsManager.Configurations;
using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Creators.FolderAlbum;
using AlbumsManager.Creators.FolderTreeAlbum;
using AlbumsManager.Models;

namespace AlbumsManager.Extensions
{
    public static class AlbumManagerBuilderExtensions
    {
        public static AlbumManager<AlbumItem> GetImagesFromFolder(string folder) =>
            new AlbumManagerBuilder<FolderAlbumManagerCreator, DefaultConfiguration, AlbumItem>()
            .AddCreator<CreatorConfiguration>(x => x.SourcePath = folder)
            .AddViewer(x => x.TakeTop = 10)
            .AddMetadataReader(x => x.Enabled = false)
            .AddEditor(x => x.Enabled = false)
            .AddUploader(x => x.Enabled = false)
            .Build();
        public static AlbumManager<AlbumDirectory> GetImagesFromFolderTree(string folder) =>
            new AlbumManagerBuilder<FolderTreeAlbumManagerCreator, DefaultConfiguration, AlbumDirectory>()
            .AddCreator<CreatorConfiguration>(x => x.SourcePath = folder)
            .AddViewer(x => x.TakeTop = 10)
            .AddMetadataReader(x => x.Enabled = false)
            .AddEditor(x => x.Enabled = false)
            .AddUploader(x => x.Enabled = false)
            .Build();
    }
}
