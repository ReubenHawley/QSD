namespace StrategyPattern.Behaviour;

public class NoJump : IJumpBehaviour
{
    public void Jump()
    {
        Console.WriteLine("No Jump");
    }
}