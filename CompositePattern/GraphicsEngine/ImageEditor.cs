using CompositePattern.GraphicsEngine.Shapes;

namespace CompositePattern.GraphicsEngine;

public class ImageEditor : Graphic
{
    public CompoundGraphic _all;

    public void Load()
    {
        _all = new CompoundGraphic();
        _all.Add(new Dot(1,2));
        _all.Add(new Circle(5,3,10));
    }

    public void GroupSelection(List<Graphic> components)
    {
        var group = new CompoundGraphic();
        foreach (var component in components)
        {
            group.Add(component);
            _all.Remove(component);
        }

        _all.Add(group);
        _all.Draw();
    }
}