namespace Head_First_Design_Patterns.Strategy_Pattern.ActionAdventureGame.Behaviour;

public class SwordBehaviour : WeaponBehaviour
{
    public void useWeapon()
    {
        Console.WriteLine("Swinging a sword");
    }
}