using Library.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace Library.ApplicationCore
{
    public interface IBookService
    {
        Task<bool> IsBookAvailable(int bookId);
    }
}
