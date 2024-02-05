using AlbumsManager.Base;
using AlbumsManager.Builders;

namespace AlbumsManager
{
    public class AlbumManagerBuilder<TCreator>
        where TCreator : IAlbumManagerCreator
    {
        private IAlbumManagerCreator _creator = null!;
        public IAlbumManagerCreatorBuilder AddCreator<TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
            where TCreatorConfiguration : class, new()
        {
            var config = new TCreatorConfiguration();
            configuration(config);
            _creator = (AlbumManagerCreatorBase<TCreatorConfiguration>)Activator.CreateInstance(typeof(TCreator), config)!;
            return new AlbumManagerCreatorBuilder(_creator);
        }
    }
}
    