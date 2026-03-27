namespace DesignPatternsNotes.Creational.Builder;

public class Product
{
    private readonly List<object> _parts = [];
    
    public void Add(string part) =>  _parts.Add(part);

    public string ListParts() => $"Product parts: {string.Join(", ", _parts)}";
}