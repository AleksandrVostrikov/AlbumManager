using AlbumsManager.Base;
using AlbumsManager.Builders;
using AlbumsManager.Configurations.Interfaces;
using AlbumsManager.Creators;

namespace AlbumsManager
{
    public sealed class AlbumManagerBuilder<TCreator, TConfiguration, TItem>
        where TCreator : IAlbumManagerCreator<TItem>
        where TConfiguration: IConfiguration, new()
        where TItem : class
    {
        private IAlbumManagerCreator<TItem> _creator = null!;

        public IAlbumManagerCreatorBuilder<TItem> AddCreator(Action<ICreatorConfiguration> configuration)
        {
            var config = new TConfiguration();
            configuration(config.CreatorConfiguration);
            _creator = (TCreator)Activator.CreateInstance(typeof(TCreator), config.CreatorConfiguration)!;
            return new AlbumManagerCreatorBuilder<TItem>(config, _creator);
        }
    }
}
    