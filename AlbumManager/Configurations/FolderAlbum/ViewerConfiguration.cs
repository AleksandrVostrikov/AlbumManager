
public class ViewerConfiguration : IViewerConfiguration
{
    private readonly List<IImageProcessor> _imageProcessors = new();
    public IEnumerable<IImageProcessor> ImageProcessors => _imageProcessors;

    public void AddImageProcessor(IImageProcessor imageProcessor)
    {
        _imageProcessors.Add(imageProcessor);
    }
}
