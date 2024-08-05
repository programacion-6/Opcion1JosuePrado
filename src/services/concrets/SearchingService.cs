namespace Opcion1JosuePrado.src.services.concrets;
using Opcion1JosuePrado.src.models;
using Opcion1JosuePrado.src.common;
using Opcion1JosuePrado.src.services.interfaces;

public class SearchingService
{
    private readonly IBookService _BookService;
    private readonly IPatronService _PatronService;
    public SearchingService (IBookService bookService, IPatronService patrongService)
    {
        _BookService = bookService;
        _PatronService = patrongService;
    }
    public Book SearchBookBy(SearchParameter parameter, string item) {
        List<Book> books = _BookService.GetItemsList();               
        return parameter switch
        {
            SearchParameter.Title => books.FirstOrDefault(b => b.Title == item),
            SearchParameter.Author => books.FirstOrDefault(b => b.Author == item),
            SearchParameter.ISBN => books.FirstOrDefault(b => b.ISBN == item),
            SearchParameter.Genre => books.FirstOrDefault(b => b.Genre == item),
            _ => throw new ArgumentException($"Parámetro de búsqueda no válido: {parameter}")
        };
    }

    public Patron SearchPatronBy(SearchParameter parameter, string item) {
        List<Patron> patrons = _PatronService.GetItemsList();               
        return parameter switch
        {
            SearchParameter.Name => patrons.FirstOrDefault(p => p.Name == item),
            SearchParameter.MembershipNumber => patrons.FirstOrDefault(p => p.MembershipNumber == item),
            SearchParameter.ContactDetails => patrons.FirstOrDefault(p => p.ContactDetails == item),
            _ => throw new ArgumentException($"Parámetro de búsqueda no válido: {parameter}")
        };
    }
}