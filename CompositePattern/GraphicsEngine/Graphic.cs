namespace CompositePattern.GraphicsEngine;

public interface Graphic
{
    public void Draw()
    {
        Console.WriteLine("Draw Graphic");
    }

    public void Move(int x,int y)
    {
        Console.WriteLine("Moving Graphic to coordinates ({0}, {1})",x,y);
    }
}