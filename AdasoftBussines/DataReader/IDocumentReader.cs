using AdasoftData;

namespace AdasoftBussines.Data
{
    interface IDocumentReader
    {
        AdDocument GetDocument();
         void SaveDocument(AdDocument document);
    }
}