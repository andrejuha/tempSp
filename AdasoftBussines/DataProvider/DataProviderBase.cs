using AdasoftData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdasoftBussines.Data
{
   public abstract class DataProviderBase<DocumentReader> : IDataProvider
    {
        public abstract AdDocument GetDocument();
        public abstract void SaveDocument(AdDocument document);
    }
}
