namespace CompositePattern.FileSystem;

public abstract class Component
{
    public string Name { get; set; }
    public int Size { get; set; }

    public bool IsComposite { get; set; }

    public Component()
    {
    }

    public virtual void Print()
    {
        throw new NotImplementedException();
    }

    public virtual int GetSize(Component component)
    {
        throw new NotImplementedException();
    }

    public virtual void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public virtual void Delete(Component component)
    {
        throw new NotImplementedException();
    }

    public abstract string Operation();
}