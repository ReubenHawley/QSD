namespace CompositePattern.FileSystem;

public class Composite : Component
{
    protected List<Component> _children = new();

    public Composite(string name)
    {
        Name = name;
        IsComposite = false;
    }

    public override void Add(Component component)
    {
        _children.Add(component);
    }

    public override string Operation()
    {
        int i = 0;
        string result = $"Branch: {Name} - ";
        foreach (var child in _children)
        {
            result += child.Operation();
            if (i != _children.Count - 1)
            {
                result += "+";
            }

            i++;
        }

        return result + "\n";
    }
}