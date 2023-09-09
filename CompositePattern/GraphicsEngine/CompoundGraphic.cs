namespace CompositePattern.GraphicsEngine;

public class CompoundGraphic : Graphic
{
    private readonly List<Graphic>? _children;

    public CompoundGraphic()
    {
        _children = new List<Graphic>();
    }

    public void Add(Graphic child)
    {
        _children!.Add(child);
    }

    public void Remove(Graphic child)
    {
        _children!.Remove(child);
    }

    public void Draw()
    {
        foreach (var child in _children)
        {
            child.Draw();
        }
    }

    public void Move(int x,int y)
    {
        foreach (var child in _children)
        {
            child.Move(x,y);
        }
    }
}