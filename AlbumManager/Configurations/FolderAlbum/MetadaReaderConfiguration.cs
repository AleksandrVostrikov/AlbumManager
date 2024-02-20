public class MetadaReaderConfiguration : IMetadataReaderConfiguration
{
    public IMetaDataReaderProcessor? MetaDataProcessor => throw new NotImplementedException();

    public void AddMetaDataReaderProcessor(TextMetadataProcessor textMetaDataReaderProcessor)
    {
        
    }
}
