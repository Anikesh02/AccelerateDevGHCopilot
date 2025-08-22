using Library.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.ApplicationCore
{
    public interface IBookItemRepository
    {
        Task<List<BookItem>> GetBookItemsByBookId(int bookId);
    }
}
