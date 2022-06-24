using IBMiX.Model.Common;

namespace IBMiX.Service.Common
{
    public interface IBookService
    {
        IEnumerable<IBook> GetBooks();
    }
}