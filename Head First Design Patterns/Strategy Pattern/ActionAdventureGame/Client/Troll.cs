using Head_First_Design_Patterns.Strategy_Pattern.ActionAdventureGame.Behaviour;

namespace Head_First_Design_Patterns.Strategy_Pattern.ActionAdventureGame.Client;

public class Troll: Character
{
    public Troll()
    {
        weaponBehaviour = new AxeBehaviour();
    }
}