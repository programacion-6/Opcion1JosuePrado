using Opcion1JosuePrado.src.models;

namespace Opcion1JosuePrado.src.services.interfaces;
public interface IPatronService : IBaseService<Patron>
{
    public int ReturnBook(string patronName, string bookTitle);
    public int BorrowBook(string patronName, string bookTitle);
}