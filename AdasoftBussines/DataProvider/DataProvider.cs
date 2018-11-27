using AdasoftBussines.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdasoftData;

namespace AdasoftBussines.DataProvider
{
    class DataProvider<XmlProjectDocumentReader> : DataProviderBase<DocumentReader>, IDataProvider
    {
        public override AdDocument GetDocument()
        {
            throw new NotImplementedException();
        }

        public override void SaveDocument(AdDocument document)
        {
            throw new NotImplementedException();
        }
    }
}
