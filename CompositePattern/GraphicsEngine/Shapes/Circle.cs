namespace CompositePattern.GraphicsEngine.Shapes;

public class Circle : Dot
{
    public int radius;
    
    public Circle(int x,int y,int radius) : base(x,y)
    {
        this.radius = radius;
    }
    
    public void Draw()
    {
        Console.WriteLine("Draw Circle");
    }
}