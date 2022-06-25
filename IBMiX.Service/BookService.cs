using IBMiX.Model.Common;
using IBMiX.Repository.Common;
using IBMiX.Service.Common;

namespace IBMiX.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository repository;
        private readonly IUserRepository userRepository;

        public BookService(IBookRepository repository, IUserRepository userRepository)
        {
            this.repository = repository;
            this.userRepository = userRepository;
        }

        public bool BorrowBook(string bookId, int userId)
        {
            try
            {
                var book = repository.GetBook(bookId);
                var user = userRepository.GetUser(userId);

                book.Borrowed = user;
                user.Books.Add(book);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<IBook> GetBooks()
        {
            return repository.GetBooks();
        }

        public bool ReturnBook(string bookId)
        {
            try
            {
                var book = repository.GetBook(bookId);
                var user = userRepository.GetUser(book.Borrowed.Id);

                book.Borrowed = null;
                user.Books.Remove(book);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}