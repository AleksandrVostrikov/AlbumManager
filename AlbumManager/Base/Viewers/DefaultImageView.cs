using AlbumsManager.Models;

namespace AlbumsManager.Base.Viewers
{
    public class DefaultImageView<TItem> : IImageView<TItem>
        where TItem : ItemBase
    {
        public DefaultImageView(IEnumerable<TItem> items)
        {
            Items = items;
        }
        public IEnumerable<TItem> Items { get; }

        public async Task<DefaultImageView<TItem>> ProcessAsync(IViewerConfiguration viewerConfiguration)
        {
            if (!viewerConfiguration.ImageProcessors.Any()) 
            {
                return this;
            }
            foreach (var item in Items)
            {
                if (!item.CanBeWatermark)
                {
                    if (item.HasItems)
                    {
                        var innerItems = (item as AlbumDirectory)?.Items ?? new List<AlbumItem>();
                        foreach (var innerItem in innerItems)
                        {
                            ExecuteProcessing(viewerConfiguration, innerItem);
                        }
                    }
                    continue;
                }
                ExecuteProcessing(viewerConfiguration, item);
            }
            return this;
        }

        public void ExecuteProcessing(IViewerConfiguration configuration, ItemBase item)
        {
            foreach (var processor in configuration.ImageProcessors)
            {
                processor.Process((AlbumItem)item);
            }
        }
    }
}
