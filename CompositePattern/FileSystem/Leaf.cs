using System.Runtime.InteropServices;

namespace CompositePattern.FileSystem;

public class Leaf : Component
{
    public Leaf(string name,int size)
    {
        Name = name;
        Size = size;
    }

    public override void Print()
    {
        Console.WriteLine($"Leaf: {Name} - {Size}");
    }

    public override int GetSize(Component component)
    {
        return Marshal.SizeOf<object>(component);
    }

    public override string Operation()
    {
        return $"Leaf({Name})";
    }
}