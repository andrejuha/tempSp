using AdasoftBussines.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdasoftData;

namespace AdasoftBussines.DataProvider
{
   public class DataProvider<T> : DataProviderBase<DocumentReader>, IDataProvider where T : IDocumentReader
    {
       T _projectDocumentReader ;

        public DataProvider(T ProjectDocumentReader)
        {
            _projectDocumentReader = ProjectDocumentReader;
        }
        public override AdDocument GetDocument()
        {
          return _projectDocumentReader.GetDocument();
        }

        public override void SaveDocument(AdDocument document)
        {
            _projectDocumentReader.SaveDocument(document);
        }
    }
}
