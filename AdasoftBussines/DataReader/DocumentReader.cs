using AdasoftData;

namespace AdasoftBussines.Data
{
   public abstract class DocumentReader : IDocumentReader
    {

        public abstract AdDocument GetDocument ();
        public abstract void SaveDocument(AdDocument document);

        

    }
}