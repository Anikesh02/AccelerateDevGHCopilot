using Library.ApplicationCore;
using Library.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Infrastructure.Data
{
    public class JsonBookItemRepository : IBookItemRepository
    {
        private readonly JsonData _jsonData;

        public JsonBookItemRepository(JsonData jsonData)
        {
            _jsonData = jsonData;
        }

        public async Task<List<BookItem>> GetBookItemsByBookId(int bookId)
        {
            await _jsonData.EnsureDataLoaded();
            return _jsonData.BookItems!.Where(bi => bi.BookId == bookId).ToList();
        }
    }
}
