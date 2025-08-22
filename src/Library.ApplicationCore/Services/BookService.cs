using Library.ApplicationCore.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Library.ApplicationCore
{
    public class BookService : IBookService
    {
        private readonly IBookItemRepository _bookItemRepository;
        private readonly ILoanRepository _loanRepository;

        public BookService(IBookItemRepository bookItemRepository, ILoanRepository loanRepository)
        {
            _bookItemRepository = bookItemRepository;
            _loanRepository = loanRepository;
        }

        public async Task<bool> IsBookAvailable(int bookId)
        {
            var bookItems = await _bookItemRepository.GetBookItemsByBookId(bookId);
            foreach (var item in bookItems)
            {
                var loan = await _loanRepository.GetActiveLoanByBookItemId(item.Id);
                if (loan == null)
                    return true; // At least one copy is available
            }
            return false; // All copies are loaned out
        }
    }
}
