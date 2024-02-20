namespace AlbumsManager.Configurations.Interfaces
{
    public interface ICreatorConfiguration
    {
        string SourcePath { get; set; }
        public bool SkipLoadingImages { get; set; }
    }
}
