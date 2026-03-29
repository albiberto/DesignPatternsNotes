using DesignPatternsNotes.Core;
using DesignPatternsNotes.Structural.Composite;
using CompositeClass = DesignPatternsNotes.Structural.Composite.Composite;
namespace DesignPatternsNotes.Structural;

public class CompositePattern(IDisplay display) : IStructural
{
    public string Name { get; } =  "Composite";
    public string Description { get; } = "Composite is a structural design pattern that lets you compose objects into tree structures and then work with there structures as if they were individual objects.";
    public string Problem { get; } = """
                                     Using th Composite pattern makes sense only when the core model of your app can be represented as a tree.
                                     
                                     For example, imagine that you have two types of objects: Products and Boxes. A Box can contain several Products as well as a number of smaller Boxes. These little Boxes can also hold some Products or even smaller Boxes, and so on.
                                     """;
    public string Solution { get; } = "The composite pattern suggest that you work with Products and Boxes through a common interface which dclares a method for calculationg the total price.";
    public string Applicability { get; } = "Use the Composite pattern when you have to implement a tree-like object structure.";
    public void Run()
    {
        var leaf = new Leaf();
        
        display.WriteSpacedLine("""
                                var leaf = new Leaf();
                                leaf.Operation();
                                """);
        
        display.WriteSpacedLine($"LEAF: {leaf.Operation()}");

        display.WriteSpacedLine("""
                                var tree = new CompositeClass();
                                var branch1 = new CompositeClass();
                                var branch2 = new CompositeClass();
                                var branch3 = new CompositeClass();
                                var branch4 = new CompositeClass();
                                
                                tree.Add(branch1);
                                tree.Add(branch2);
                                branch1.Add(new Leaf());
                                branch1.Add(new Leaf());
                                branch2.Add(branch3);
                                branch2.Add(branch4);
                                branch3.Add(new Leaf());
                                branch3.Add(new Leaf());
                                branch4.Add(new Leaf());
                                """);
        
        var tree = new CompositeClass();
        var branch1 = new CompositeClass();
        var branch2 = new CompositeClass();
        var branch3 = new CompositeClass();
        var branch4 = new CompositeClass();

        tree.Add(branch1);
        tree.Add(branch2);
        branch1.Add(new Leaf());
        branch1.Add(new Leaf());
        branch2.Add(branch3);
        branch2.Add(branch4);
        branch3.Add(new Leaf());
        branch3.Add(new Leaf());
        branch4.Add(new Leaf());
        
        display.WriteSpacedLine($"TREE: {tree.Operation()}");
    }
}