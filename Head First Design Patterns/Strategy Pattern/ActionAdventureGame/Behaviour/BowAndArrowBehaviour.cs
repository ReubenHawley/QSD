namespace Head_First_Design_Patterns.Strategy_Pattern.ActionAdventureGame.Behaviour;

public class BowAndArrowBehaviour : WeaponBehaviour
{
    public void useWeapon()
    {
        Console.WriteLine("Shooting an arrow with a bow");
    }
}