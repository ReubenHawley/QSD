namespace CompositePattern.GraphicsEngine.Shapes;

public class Dot : Graphic
{
    public int X;
    public int Y;

    public Dot(int x,int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Draw()
    {
        Console.WriteLine("Draw Dot");
    }

    public void Move(int x,int y)
    {
        X += x;
        Y += y;
    }
}