using Autofac;
using AutoMapper;
using IBMiX.Model;
using IBMiX.Model.Common;
using IBMiX.Model.Xml;
using IBMiX.Repository.Common;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace IBMiX.Repository
{
    public class BookRepository : IBookRepository
    {
        private List<IBook> books;
        private readonly string xmlPath;
        private readonly IMapper mapper;

        public BookRepository(IMapper mapper)
        {
            xmlPath = Path.GetDirectoryName(Environment.CurrentDirectory) + "\\books.xml";
            this.mapper = mapper;
            books = LoadBooks();
        }

        private List<IBook> LoadBooks()
        {
            try
            {
                var result = new List<IBook>();
                var reader = new XmlSerializer(typeof(Catalog));
                var file = new StreamReader(xmlPath);
                var readXml = (Catalog)reader.Deserialize(file);
                file.Close();
                foreach (var item in readXml.Books)
                {
                    result.Add(mapper.Map<IBook>(item));
                }
                return result;
            }
            catch (Exception)
            {
                return default;
            }
        }

        public IEnumerable<IBook> GetBooks()
        {
            return books;
        }
    }
}