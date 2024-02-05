using AlbumsManager;
using AlbumsManager.Creators.FolderAlbum;

//builder.AddCreator<FolderTreeAlbumCreator, FolderTreeAlbumCreatorConfiguration>(x => x.SourceRootPath = "G:\\CommonFolder");
var builder = new AlbumManagerBuilder()
    .AddCreator<FolderAlbumCreator, FolderAlbumCreatorConfiguration>(x => x.SourcePath = "G:\\CommonFolder")
    .AddViewer<FolderAlbumViewerConfiguration>(x => x.TakeTop = 10)
    .AddMetadataReader<FolderAlbumMetadaReaderConfiguration>(x => x.Enabled = false)
    .AddEditor<FolderAlbumEditorConfiguration>(x => x.Enabled = false)
    .AddUploader<FolderAlbumUploaderConfiguration>(x => x.Enabled = false);

var manager = builder.Build();

Console.WriteLine(manager.ToString());

var view = manager.GetView();

foreach (var item in view.Items)
{
    Console.WriteLine($"File name: {item.FileName} ---- File size: {item.FileSize}");
}
