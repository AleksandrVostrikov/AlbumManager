using AlbumsManager.Base;
using AlbumsManager.Base.Builders;
using AlbumsManager.Builders;
using AlbumsManager.Configurations.Interfaces;
using AlbumsManager.Creators;
using AlbumsManager.Models;

namespace AlbumsManager
{
    public sealed class AlbumManagerBuilder<TCreator, TConfiguration, TItem>
        where TCreator : IAlbumManagerCreator<TItem>
        where TConfiguration: IConfiguration, new()
        where TItem : ItemBase
    {
        private IAlbumManagerCreator<TItem> _creator = null!;

        public IAlbumManagerCreatorBuilder<TItem> AddCreator<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
        where TCreatorConfiguration : ICreatorConfiguration
        {
            var config = new TConfiguration();
            configuration((TCreatorConfiguration)config.CreatorConfiguration);
            _creator = (TCreator)Activator.CreateInstance(typeof(TCreator), config)!;
            return new AlbumManagerCreatorBuilder<TItem>(config, _creator);
        }
    }
}
    