using StrategyPattern.Behaviour;

namespace StrategyPattern.Character;

public interface ICharacter
{
    public IJumpBehaviour JumpBehaviour { get; set; }
    
    public void SetJumpBehaviour(IJumpBehaviour jumpBehaviour)
    {
        this.JumpBehaviour = jumpBehaviour;
    }
}