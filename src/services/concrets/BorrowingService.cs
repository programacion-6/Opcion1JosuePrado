using Opcion1JosuePrado.src.models;
using Opcion1JosuePrado.src.services.interfaces;

namespace Opcion1JosuePrado.src.services.concrets;
public class BorrowingService : IBorrowingService
{
    public List<Borrowing> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int Add(Borrowing item)
    {
        Items.Add(item);
        return 0;
    }

    public int CheckBorrowedBook(string bookTitle)
    {
        throw new NotImplementedException();
    }

    public int Delete(Borrowing item)
    {
        if (Items.Remove(item)) {
            return 0;    
        }
        return 1;
    }

    public Borrowing GetItem(string itemId)
    {
        Borrowing borrowingFinded = Items.Find(b => b.BookTitle == itemId);

        if (borrowingFinded != null) 
        {
            return borrowingFinded;
        }
        throw new NullReferenceException();
    }

    public List<Borrowing> GetItemsList()
    {
        return Items;
    }

    public int Update(string itemId, Borrowing newItem)
    {
        Borrowing borrowingToUpdate = GetItem(itemId);   

        if (borrowingToUpdate != null)
        {
            borrowingToUpdate = newItem;
            return 0;
        }
        return 1;
    }
}