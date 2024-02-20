public interface IViewerConfiguration
{
    IEnumerable<IImageProcessor> ImageProcessors { get; }
    void AddImageProcessor(IImageProcessor imageProcessor);
}
