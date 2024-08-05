using Opcion1JosuePrado.src.models;
using Opcion1JosuePrado.src.services.interfaces;

namespace Opcion1JosuePrado.src.services.concrets;
public class PatronService : IPatronService
{
    public List<Patron> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int Add(Patron item)
    {
        Items.Add(item);
        return 0;
    }

    public int BorrowBook(string patronName, string bookTitle)
    {
        throw new NotImplementedException();
    }

    public int Delete(Patron item)
    {
        if (Items.Remove(item)) 
        {
            return 0;    
        }
        return 1;
    }

    public int ReturnBook(string patronName, string bookTitle)
    {
        throw new NotImplementedException();
    }

    public Patron GetItem(string itemId)
    {
        Patron patronFinded = Items.Find(b => b.Name == itemId);

        if (patronFinded != null) 
        {
            return patronFinded;
        }
        throw new NullReferenceException();
    }

    public List<Patron> GetItemsList()
    {
        return Items;
    }

    public int Update(string itemId, Patron newItem)
    {
        Patron patronToUpdate = GetItem(itemId);   

        if (patronToUpdate != null)
        {
            patronToUpdate = newItem;
            return 0;
        }
        return 1;
    }
}
