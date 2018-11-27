using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdasoftData;
using System.Xml.Linq;
using System.Xml;
using AdasoftData.model;
using System.Xml.Schema;
using System.IO;

namespace AdasoftBussines.Data
{
    public class XmlProjectDocumentReader : DocumentReader,IDocumentReader
    {
        string path { get; set; }
        public override AdDocument GetDocument()
        {
            ZoznamProjektov<ProjectItem>  zoznam = new ZoznamProjektov<ProjectItem>();
            List<ProjectItem> listItems = new List<ProjectItem>();
            try
            {
                XElement xelement = XElement.Load(path);
                IEnumerable<XElement> items = xelement.Elements();
               
                foreach (var item in items)
                {
                    int _id = int.Parse(item.Element("id").Value);
                    string  _abreviation = item.Element("abreviation").Value;
                    string _customer = item.Element("customer").Value;
                    string _name = item.Element("name").Value;

                    listItems.Add(
                                  new ProjectItem()
                                  {
                                      Abreviation = _abreviation,
                                      Customer = _customer,
                                      Name = _name,
                                      Id = _id,
                                  });
                }
            }
            catch (Exception e)
            {

            }
            zoznam.Items = listItems;
            zoznam.Path = path;
            
            return (AdDocument)(zoznam);
        }

        public override void SaveDocument(AdDocument document)
        {
            ZoznamProjektov<ProjectItem> zoznam = (ZoznamProjektov<ProjectItem>)document;

            XDocument xDoc = new XDocument(new XDeclaration("Version", "Unicode type", null));
            XElement root = new XElement("GenericList");
            //For this example we are using a Schema to validate our XML
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", path);
            try
            {
                foreach (ProjectItem item in zoznam.Items)
                {

                    root.Add(

                        new XElement("project",
                                new XElement("name", item.Name),
                                new XElement("id", item.Id),
                                new XElement("customer", item.Customer),
                                new XElement("customer", item.Abreviation)

                        ));
                }
                xDoc.Add(root);
            }
            catch(Exception e)
            {

            }

            try
            {
                string errors = "";
                xDoc.Validate(schemas, (obj, err) =>
                {
                    errors += err.Message + "/n";
                });

                StringWriter writer = new StringWriter();
                XmlWriter xWrite = XmlWriter.Create(writer);
                xDoc.Save(xWrite);
                xWrite.Close();

                if (errors == "")
                {
                    xDoc.Save(path);
                }
            }
            catch(Exception e)
            { }
        }
    }
    }
}
