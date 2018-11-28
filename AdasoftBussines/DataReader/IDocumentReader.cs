using AdasoftData;

namespace AdasoftBussines.Data
{
    public interface IDocumentReader
    {
        AdDocument GetDocument();
         void SaveDocument(AdDocument document);
    }
}