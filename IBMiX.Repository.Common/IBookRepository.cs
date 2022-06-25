using IBMiX.Model.Common;

namespace IBMiX.Repository.Common
{
    public interface IBookRepository
    {
        List<IBook> GetBooks();
        IBook GetBook(string id);
    }
}