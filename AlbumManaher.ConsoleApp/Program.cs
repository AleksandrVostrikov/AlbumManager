using AlbumsManager;
using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Creators.FolderAlbum;
using AlbumsManager.Creators.FolderTreeAlbum;
using AlbumsManager.Models;

//builder.AddCreator<FolderTreeAlbumCreator, FolderTreeAlbumCreatorConfiguration>(x => x.SourceRootPath = "G:\\CommonFolder");

var manager = await new AlbumManagerBuilder<FolderAlbumManagerCreator, DefaultConfiguration, AlbumItem>()
    .AddCreator<CreatorConfiguration>(x => x.SourcePath = "G:\\CommonFolder")
    .AddViewer<ViewerConfiguration>(_ => {})
    .AddMetadataReader<MetadaReaderConfiguration>(_ => {})
    .AddEditor<EditorConfiguration>(x => x.Enabled = false)
    .AddUploader<UploaderConfiguration>(x => x.Enabled = false)
    .BuildAsync();

Console.WriteLine(manager.ToString());

var view = manager.GetViewAsync();

//foreach (var item in view.Items)
//{
//    Console.WriteLine($"File name: {item.FileName} ---- File size: {(item.FileSize / 1024):F2} kb");
//}

//foreach (var item in view.Items)
//{
//    Console.WriteLine($"File name: {item.DirectotyName} ---- File size: {item.Items?.Count() ?? 0}");
//}
