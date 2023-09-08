using StrategyPattern.Behaviour;

namespace StrategyPattern.Character;

public class Player : ICharacter
{
    public IJumpBehaviour JumpBehaviour { get; set; }
    
    public Player()
    {
        JumpBehaviour = new NormalJump();
    }
    
    public void Jump()
    {
        JumpBehaviour.Jump();
    }

    public void SetJumpBehaviour(IJumpBehaviour jumpBehaviour)
    {
        this.JumpBehaviour = jumpBehaviour;
    }
}