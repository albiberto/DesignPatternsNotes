namespace DesignPatternsNotes.Structural.Composite;

public class Composite : Component
{
    private readonly List<Component> _children = [];

    public override void Add(Component component) => _children.Add(component);

    public override void Remove(Component component) => _children.Remove(component);

    public override string Operation()
    {
        var i = 0;
        var result = "Branch(";
        foreach (var child in _children)
        {
            result += child.Operation();
            if (i == _children.Count - 1) continue;

            result += "+";
            i++;
        }

        return result + ")";
    }
}