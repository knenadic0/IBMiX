using IBMiX.Common;
using System.Xml.Serialization;

namespace IBMiX.Model.Common
{
    public interface IBook
    {
        string Id { get; set; }
        string Author { get; set; }
        string Title { get; set; }
        string Genre { get; set; }
        float Price { get; set; }
        DateTime PublishDate { get; set; }
        string Description { get; set; }
    }
}