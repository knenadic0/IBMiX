using IBMiX.Model.Common;
using IBMiX.Repository.Common;
using IBMiX.Service.Common;

namespace IBMiX.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository repository;

        public BookService(IBookRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<IBook> GetBooks()
        {
            return repository.GetBooks();
        }
    }
}