using System.Collections;

namespace DesignPatternsNotes.Behavioral.Iterator;

public interface IIterator : IEnumerator
{
    public int Key { get; }
}