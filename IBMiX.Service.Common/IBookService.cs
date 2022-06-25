using IBMiX.Model.Common;

namespace IBMiX.Service.Common
{
    public interface IBookService
    {
        List<IBook> GetBooks();
        bool ReturnBook(string bookId);

        bool BorrowBook(string bookId, int userId);
    }
}