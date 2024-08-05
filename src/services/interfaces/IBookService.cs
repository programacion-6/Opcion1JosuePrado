using Opcion1JosuePrado.src.models;

namespace Opcion1JosuePrado.src.services.interfaces;
public interface IBookService : IBaseService<Book>
{
    public List<Book> GroupByGender(string gender);
}