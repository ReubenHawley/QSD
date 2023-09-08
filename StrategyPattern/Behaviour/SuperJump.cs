namespace StrategyPattern.Behaviour;

public class SuperJump : IJumpBehaviour
{
    public void Jump()
    {
        Console.WriteLine("Super Jump");
    }
}