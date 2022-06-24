using IBMiX.Model.Common;

namespace IBMiX.Repository.Common
{
    public interface IBookRepository
    {
        IEnumerable<IBook> GetBooks();
    }
}