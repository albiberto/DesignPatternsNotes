using DesignPatternsNotes.Core;
using DesignPatternsNotes.Creational.Abstract;
using DesignPatternsNotes.Creational.Prototype;

namespace DesignPatternsNotes.Creational;

public class PrototypePattern(IDisplay display) : ICreational
{
    public string Name { get; } = "Prototype";

    public string Description { get; } = "Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes";
    public string Problem { get; } = """
                                     Say you have an object, and you want to create an exact copy of it.
                                     How would you do it?
                                     First, you have to go through all the fields of the original object and copy their values over the new object.
                                     
                                     Nice! But there's a catch. Not all objects can be copied that way because some of the object's fields may be private and visible from outside of the object itself. 
                                     """;

    public string Solution { get; } = """
                                      The Prototype pattern delegates the cloning process to the actual objects that are being cloned.
                                      The pattern declares a common interface lets you clone an object without coupling your code to the class of that object.
                                      Usually, such an interface contains a single clone method.
                                      """;

    public string Applicability { get; } = "Use the Prototype pattern when your code shouldn't depend on the concrete classes of objects that you need to copy.";
    public void Run()
    {
        var p1 = new Person
        {
            Age = 38,
            BirthDate = new(1988, 6, 23),
            Name = "Alberto",
            IdInfo = new(666)
        };

        var p2 = p1.ShallowCopy();
        var p3 = p1.DeepCopy();
        
        display.WriteSpacedLine("""
                                var p1 = new Person
                                {
                                    Age = 38,
                                    BirthDate = new(1988, 6, 23),
                                    Name = "Alberto",
                                    IdInfo = new(666)
                                };
                                
                                var p2 = p1.ShallowCopy();
                                var p3 = p1.DeepCopy();
                                """);
        
        display.WriteLine("Original values of p1, p2, p3:");
        DisplayValues("p1" , p1);
        DisplayValues("p2", p2);
        DisplayValues("p3", p3);
        
        p1.Age = 2;
        p1.BirthDate = new(2024, 3, 21);
        p1.Name = "Giorgia";
        p1.IdInfo.IdNumber = 7878;

        display.WriteLine();
        display.WriteSpacedLine("""
                                p1.Age = 2;
                                p1.BirthDate = new(2024, 3, 21);
                                p1.Name = "Giorgia";
                                p1.IdInfo.IdNumber = 7878;
                                """);
        
        display.WriteLine("Values of p1, p2, p3:");
        DisplayValues("p1" , p1);
        DisplayValues("p2", p2);
        DisplayValues("p3", p3);
    }

    private void DisplayValues(string key, Person p)
    {
        display.WriteLine($"{key} instance values:");
        display.WriteLine($"Name: {p.Name}, Age: {p.Age}, BirthDate: {p.BirthDate:dd/MM/yy}");
        display.WriteLine($"ID#: {p.IdInfo?.IdNumber}");
    }
}