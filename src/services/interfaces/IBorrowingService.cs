using Opcion1JosuePrado.src.models;

namespace Opcion1JosuePrado.src.services.interfaces;
public interface IBorrowingService : IBaseService<Borrowing>
{
    public int CheckBorrowedBook(string bookTitle);
}