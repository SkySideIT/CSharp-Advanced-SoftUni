
using System.Collections;

namespace _01.ListyIterator;

public class ListyIterator<T> : IEnumerable<T>
{
    private readonly List<T> _list;
    private int _index;

    public ListyIterator(IEnumerable<T> values)
    {
        this._list = new List<T>(values);
    }

    public T Current => this.GetCurrentElement();

    public bool Move()
    {
        if (!HasNext()) return false;
        
        this._index++;
        return true;
    }

    public bool HasNext()
        => this._index + 1 < this._list.Count;

    private T GetCurrentElement()
    {
        if (this._index < 0 || this._index > this._list.Count)
        {
            throw new InvalidOperationException("Invalid operation.");
        }

        return this._list[this._index];
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this._list.Count; i++)
        {
            yield return this._list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();
}
