using AlbumsManager.Base;

namespace AlbumsManager.Creators.FolderTreeAlbum
{
    public class FolderTreeAlbumCreator : AlbumCreatorBase<FolderTreeAlbumCreatorConfiguration>
    {
        public FolderTreeAlbumCreator(FolderTreeAlbumCreatorConfiguration configuration) : base(configuration) { }

        public override List<AlbumItem> GetItems()
        {
            var result = new List<AlbumItem>();

            if (!Path.Exists(Config.SourceRootPath))
            {
                return new List<AlbumItem>();
            }

            var directoryInfo = new DirectoryInfo(Config.SourceRootPath);

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
                    result.Add(new AlbumItem()
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

                result.Add(new AlbumItem()
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
