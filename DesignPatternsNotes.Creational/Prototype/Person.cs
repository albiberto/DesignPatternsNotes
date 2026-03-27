namespace DesignPatternsNotes.Creational.Prototype;

public class Person
{
    public int Age;
    public DateOnly BirthDate;
    public string? Name;
    public IdInfo? IdInfo;

    public Person ShallowCopy() => (Person)MemberwiseClone();
    
    public Person DeepCopy()
    {
        var clone = (Person)MemberwiseClone();
        clone.IdInfo = new(IdInfo?.IdNumber);
        clone.Name = $"{Name}";
        return clone;
    }
}