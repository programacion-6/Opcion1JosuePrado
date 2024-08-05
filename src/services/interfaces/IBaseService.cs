namespace Opcion1JosuePrado.src.services.interfaces;

public interface IBaseService<T> where T : new()
{
    public List<T> Items { get; set; }
    public int Add(T item);
    public List<T> GetItemsList();
    public T GetItem(string itemId);
    public int Delete(T item);
    public int Update(string itemId, T newItem);
}