using AdasoftData;

namespace AdasoftBussines.Data
{
    public interface IDataProvider
    {
        AdDocument GetDocument();
        void SaveDocument(AdDocument document);
    }
}