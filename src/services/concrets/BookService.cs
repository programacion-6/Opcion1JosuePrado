using Opcion1JosuePrado.src.models;
using Opcion1JosuePrado.src.services.interfaces;

namespace Opcion1JosuePrado.src.services.concrets;
public class BookService : IBookService
{
    public required List<Book> Items { get; set; }

    public int Add(Book item)
    {
        Items.Add(item);
        return 0;
    }

    public int Delete(Book item)
    {
        if (Items.Remove(item)) {
            return 0;    
        }
        return 1;
        
    }

    public List<Book> GroupByGender(string gender)
    {
        throw new NotImplementedException();
    }

    public Book GetItem(string itemId)
    {
        Book bookFinded = Items.Find(b => b.Title == itemId);

        if (bookFinded != null) 
        {
            return bookFinded;
        }
        throw new NullReferenceException();
    }

    public List<Book> GetItemsList()
    {
        return Items;
    }

    public int Update(string itemId, Book newItem)
    {
        Book bookToUpdate = GetItem(itemId);   

        if (bookToUpdate != null)
        {
            bookToUpdate = newItem;
            return 0;
        }
        return 1;
    }
}