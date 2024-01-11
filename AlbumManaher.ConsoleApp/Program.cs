using AlbumsManager;
using AlbumsManager.Creators.FolderTreeAlbum;

var builder = new AlbumManagerBuilder();
//builder.AddCreator<FolderAlbumCreator, FolderAlbumCreatorConfiguration>(x => x.SourcePath = "G:\\CommonFolder");
builder.AddCreator<FolderTreeAlbumCreator, FolderTreeAlbumCreatorConfiguration>(x => x.SourceRootPath = "G:\\CommonFolder");

var manager = builder.Build();

Console.WriteLine(manager.ToString());

var view = manager.GetView();

foreach (var item in view.Items)
{
    Console.WriteLine($"File name: {item.FileName} ---- File size: {item.FileSize}");
}