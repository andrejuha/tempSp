using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdasoftData;
using System.Xml.Linq;
using System.Xml;
using AdasoftData.model;

namespace AdasoftBussines.Data
{
    class XmlProjectDocumentReader : DocumentReader,IDocumentReader
    {
        string path { get; set; }
        public override AdDocument GetDocument()
        {
            try
            {
                //XElement booksFromFile = XElement.Load(path);
                //Console.WriteLine(booksFromFile);
                XmlReader r = XmlReader.Create(path);
                while (r.NodeType != XmlNodeType.Element)
                    r.Read();
                XElement e = XElement.Load(r);
            }
            catch (Exception e)
            {

            }
            return (AdDocument)new ZoznamProjektov<ProjectItem>();
        }

        public override void SaveDocument(AdDocument document)
        {
            throw new NotImplementedException();
        }
    }
}
