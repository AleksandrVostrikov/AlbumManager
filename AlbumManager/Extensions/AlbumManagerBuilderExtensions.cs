using AlbumsManager.Configurations;
using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Creators.FolderAlbum;
using AlbumsManager.Creators.FolderTreeAlbum;
using AlbumsManager.ImageProcessors;
using AlbumsManager.Models;
using System.Text;

namespace AlbumsManager.Extensions
{
    public static class AlbumManagerBuilderExtensions
    {
        public static async Task<AlbumManager<AlbumItem>> GetImagesFromFolderAsync(string folder) =>
            await new AlbumManagerBuilder<FolderAlbumManagerCreator, DefaultConfiguration, AlbumItem>()
            .AddCreator<CreatorConfiguration>(x => { x.SourcePath = folder; x.SkipLoadingImages = false; })
            .AddViewer<ViewerConfiguration>(x =>
            {
                x.AddImageProcessor(new TextWatermarkImageProcessor());
            })
            .AddMetadataReader<MetadaReaderConfiguration>(x =>
            {
                x.AddMetaDataReaderProcessor(new TextMetadataProcessor());
            })
            .AddEditor<EditorConfiguration>(x => x.Enabled = false)
            .AddUploader<UploaderConfiguration>(x => x.Enabled = false)
            .BuildAsync();
        public static async Task<AlbumManager<AlbumDirectory>> GetImagesFromFolderTreesAsync(string folder, bool skipped) =>
            await new AlbumManagerBuilder<FolderTreeAlbumManagerCreator, DefaultConfiguration, AlbumDirectory>()
            .AddCreator<CreatorConfiguration>(x => 
            {
                x.SourcePath = folder;
                x.SkipLoadingImages = skipped;
            })
            .AddViewer<ViewerConfiguration>(x =>
            {
                x.AddImageProcessor(new TextWatermarkImageProcessor());
            })
            .AddMetadataReader<MetadaReaderConfiguration>(x => 
            {
                x.AddMetaDataReaderProcessor(new TextMetadataProcessor());
            })
            .AddEditor<EditorConfiguration>(x => x.Enabled = false)
            .AddUploader<UploaderConfiguration>(x => x.Enabled = false)
            .BuildAsync();
    }
}
