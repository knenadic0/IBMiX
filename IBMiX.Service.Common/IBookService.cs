using IBMiX.Model.Common;

namespace IBMiX.Service.Common
{
    public interface IBookService
    {
        IEnumerable<IBook> GetBooks();
        bool ReturnBook(string bookId);

        bool BorrowBook(string bookId, int userId);
    }
}