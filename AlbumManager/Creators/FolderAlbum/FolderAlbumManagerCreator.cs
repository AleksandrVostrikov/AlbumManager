using AlbumsManager.Base;
using AlbumsManager.Configurations.FolderAlbum;
using AlbumsManager.Models;

namespace AlbumsManager.Creators.FolderAlbum
{
    public sealed class FolderAlbumManagerCreator : AlbumManagerCreatorBase<DefaultConfiguration, AlbumItem>
    {
        public FolderAlbumManagerCreator(DefaultConfiguration configuration) : base(configuration) { }


        public override async Task<IEnumerable<AlbumItem>> GetItemsAsync()
        {
            if (!Path.Exists(Config.CreatorConfiguration.SourcePath))
            {
                return new List<AlbumItem>();
            }

            var directory = new DirectoryInfo(Config.CreatorConfiguration.SourcePath);
            var files = directory.GetFiles();

            if (!files.Any())
            {
                return new List<AlbumItem>();
            }

            return files.Select(f => new AlbumItem
            {
                Name = f.Name,
                Description = f.DirectoryName,
                FileSize = f.Length,
                OriginalBytes = File.ReadAllBytes(Path.Combine(Config.CreatorConfiguration.SourcePath, f.Name))
            }).ToList();
        }
    }
}
