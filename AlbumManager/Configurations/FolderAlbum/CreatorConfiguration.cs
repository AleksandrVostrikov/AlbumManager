using AlbumsManager.Configurations.Interfaces;

namespace AlbumsManager.Configurations.FolderAlbum
{
    public class CreatorConfiguration : ICreatorConfiguration
    {
        public string SourcePath { get; set; } = null!;

    }
}
