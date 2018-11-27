using AdasoftData;

namespace AdasoftBussines.Data
{
    abstract class DocumentReader : IDocumentReader
    {

        public abstract AdDocument GetDocument ();
        public abstract void SaveDocument(AdDocument document);

        

    }
}