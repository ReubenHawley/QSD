namespace StrategyPattern.Behaviour;

public class NormalJump : IJumpBehaviour
{
    public void Jump()
    {
        Console.WriteLine("Normal Jump");
    }
}