using AlbumsManager.Base;
using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Configurations.Interfaces;
using AlbumsManager.Models;

namespace AlbumsManager.Creators.FolderTreeAlbum
{
    public sealed class FolderTreeAlbumManagerCreator : AlbumManagerCreatorBase<DefaultConfiguration, AlbumDirectory>
    {
        public FolderTreeAlbumManagerCreator(DefaultConfiguration configuration) : base(configuration) { }

        public override async Task<IEnumerable<AlbumDirectory>> GetItemsAsync()
        {
            var result = new List<AlbumDirectory>();

            if (!Path.Exists(Config.CreatorConfiguration.SourcePath))
            {
                return new List<AlbumDirectory>();
            }

            var directoryInfo = new DirectoryInfo(Config.CreatorConfiguration.SourcePath);

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
                        Name = directory.Name
                    });
                    continue;
                }

                var files = fileInfos.Select(f => new AlbumItem
                {
                    Name = f.Name,
                    Description = f.CreationTime.ToString(),
                    FileSize = f.Length,
                    OriginalBytes = File.ReadAllBytes(Path.Combine(Config.CreatorConfiguration.SourcePath, f.Name))
                }).ToList();

                result.Add(new AlbumDirectory()
                {
                    Items = files,
                    Description = $"Total files in directory: {files.Count}",
                    Name = directory.Name
                });
            }

            return result;
        }
    }
}
