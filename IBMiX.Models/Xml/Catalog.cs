using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IBMiX.Model.Xml
{
    [XmlRoot(ElementName = "catalog")]
    public class Catalog
    {
        [XmlElement(ElementName = "book")]
        public List<BookXml> Books { get; set; }
    }
}
