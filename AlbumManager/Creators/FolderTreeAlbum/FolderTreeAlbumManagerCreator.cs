using AlbumsManager.Base;
using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Models;

namespace AlbumsManager.Creators.FolderTreeAlbum
{
    public sealed class FolderTreeAlbumManagerCreator : AlbumManagerCreatorBase<CreatorConfiguration, AlbumDirectory>
    {
        public FolderTreeAlbumManagerCreator(CreatorConfiguration configuration) : base(configuration) { }

        public override List<AlbumDirectory> GetItems()
        {
            var result = new List<AlbumDirectory>();

            if (!Path.Exists(Config.SourcePath))
            {
                return new List<AlbumDirectory>();
            }

            var directoryInfo = new DirectoryInfo(Config.SourcePath);

            var directories = directoryInfo.GetDirectories();

            if (!directories.Any())
            {
                return result;
            }

            foreach (var directory in directories)
            {
                var fileInfos = directory.GetFiles();
                if (!fileInfos.Any())
                {
                    result.Add(new AlbumDirectory()
                    {
                        Description = $"Files not found in directory.",
                        DirectotyName = directory.Name
                    });
                    continue;
                }

                var files = fileInfos.Select(f => new AlbumItem
                {
                    FileName = f.Name,
                    Description = f.CreationTime.ToString(),
                    FileSize = f.Length,
                }).ToList();

                result.Add(new AlbumDirectory()
                {
                    Items = files,
                    Description = $"Total files in directory: {files.Count}",
                    DirectotyName = directory.Name
                });
            }

            return result;
        }
    }
}
