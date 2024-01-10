public class Stack()
{
    private List<Object> _items;

    private List<Object> Items
    {
        get { return _items; }
        set { _items = value; }
    }

    public void Push(Object obj)
    {
        Items.Add(obj);
    }


    public void Pop()
    {
        Items.Reverse();
    }


    public void Clear()
    {
        Items.Clear();
    }
}
