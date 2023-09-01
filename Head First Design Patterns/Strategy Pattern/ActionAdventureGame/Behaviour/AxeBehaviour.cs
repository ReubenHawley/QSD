namespace Head_First_Design_Patterns.Strategy_Pattern.ActionAdventureGame.Behaviour;

public class AxeBehaviour : WeaponBehaviour
{
    public void useWeapon()
    {
        Console.WriteLine("Chopping with an axe");
    }
}