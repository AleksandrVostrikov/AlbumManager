using AlbumsManager.Base;
using AlbumsManager.Builders;

namespace AlbumsManager
{
    public class AlbumManagerBuilder
    {
        private ICreator _creator = null!;
        public IAlbumManagerCreatorBuilder AddCreator<TCreator, TCreatorConfiguration>(Action<TCreatorConfiguration> configuration)
            where TCreator : AlbumCreatorBase<TCreatorConfiguration>
            where TCreatorConfiguration : class, new()
        {
            var config = new TCreatorConfiguration();
            configuration(config);
            _creator = (AlbumCreatorBase<TCreatorConfiguration>)Activator.CreateInstance(typeof(TCreator), config)!;
            return new AlbumManagerCreatorBuilder(_creator);
        }
    }
}
    