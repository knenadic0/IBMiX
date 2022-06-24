using IBMiX.Common;
using IBMiX.Model.Common;
using System.Xml.Serialization;

namespace IBMiX.Model.Xml
{
    [XmlRoot(ElementName = "book")]
    public class BookXml
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "author")]
        public Author Author { get; set; }
        [XmlElement(ElementName = "title")]
        public Title Title { get; set; }
        [XmlElement(ElementName = "genre")]
        public Genre Genre { get; set; }
        [XmlElement(ElementName = "price")]
        public Price Price { get; set; }
        [XmlElement(ElementName = "publish_date")]
        public PublishDate PublishDate { get; set; }
        [XmlElement(ElementName = "description")]
        public Description Description { get; set; }

    }

    [XmlRoot(ElementName = "author")]
    public class Author
    {
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "title")]
    public class Title 
    {
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "genre")]
    public class Genre
    {
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "price")]
    public class Price
    {
        [XmlText]
        public float Text { get; set; }
    }

    [XmlRoot(ElementName = "publish_date")]
    public class PublishDate
    {
        [XmlText]
        public DateTime Text { get; set; }
    }

    [XmlRoot(ElementName = "description")]
    public class Description
    {
        [XmlText]
        public string Text { get; set; }
    }
}