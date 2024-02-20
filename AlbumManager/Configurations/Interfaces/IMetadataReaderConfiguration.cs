public interface IMetadataReaderConfiguration
{
    IMetaDataReaderProcessor? MetaDataProcessor { get; }
    public void AddMetaDataReaderProcessor(TextMetadataProcessor textMetaDataReaderProcessor);

}

public class TextMetadataProcessor
{

}

public interface IMetaDataReaderProcessor
{

}