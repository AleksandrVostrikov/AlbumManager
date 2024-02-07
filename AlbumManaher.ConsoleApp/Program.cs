using AlbumsManager;
using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Creators.FolderAlbum;
using AlbumsManager.Creators.FolderTreeAlbum;
using AlbumsManager.Models;

//builder.AddCreator<FolderTreeAlbumCreator, FolderTreeAlbumCreatorConfiguration>(x => x.SourceRootPath = "G:\\CommonFolder");

var manager = new AlbumManagerBuilder<FolderAlbumManagerCreator, DefaultConfiguration, AlbumItem>()
    .AddCreator<CreatorConfiguration>(x => x.SourcePath = "G:\\CommonFolder")
    .AddViewer(x => x.TakeTop = 10)
    .AddMetadataReader(x => x.Enabled = false)
    .AddEditor(x => x.Enabled = false)
    .AddUploader(x => x.Enabled = false)
    .Build();

Console.WriteLine(manager.ToString());

var view = manager.GetView();

foreach (var item in view.Items)
{
    Console.WriteLine($"File name: {item.FileName} ---- File size: {(item.FileSize / 1024):F2} kb");
}

//foreach (var item in view.Items)
//{
//    Console.WriteLine($"File name: {item.DirectotyName} ---- File size: {item.Items?.Count() ?? 0}");
//}
