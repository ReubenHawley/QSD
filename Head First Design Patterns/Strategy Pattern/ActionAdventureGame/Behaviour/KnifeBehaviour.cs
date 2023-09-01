namespace Head_First_Design_Patterns.Strategy_Pattern.ActionAdventureGame.Behaviour;

public class KnifeBehaviour : WeaponBehaviour
{
    public void useWeapon()
    {
        Console.WriteLine("Cutting with a knife");
    }
}