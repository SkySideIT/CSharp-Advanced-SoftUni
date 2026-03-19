

using System.Collections;

namespace _04.Froggy;

public class Lake : IEnumerable<int>
{
    private readonly int[] _stones;

    public Lake(IEnumerable<int> stones)
    {
        this._stones = stones.ToArray();
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this._stones.Length; i+=2)
        {
            yield return this._stones[i];
        }

        for (int i = this._stones.Length - this._stones.Length % 2 - 1; i >= 0; i-=2)
        {
            yield return this._stones[i];
        } 
    }

    IEnumerator IEnumerable.GetEnumerator()
        => this.GetEnumerator();
}
