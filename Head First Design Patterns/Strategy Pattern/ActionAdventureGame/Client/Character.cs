using Head_First_Design_Patterns.Strategy_Pattern.ActionAdventureGame.Behaviour;

namespace Head_First_Design_Patterns.Strategy_Pattern.ActionAdventureGame.Client;

public abstract class Character
{
    public WeaponBehaviour weaponBehaviour;
    
    public void fight()
    {
        weaponBehaviour.useWeapon();
    }
    
    public void setWeapon(WeaponBehaviour wb)
    {
        weaponBehaviour = wb;
    }
}

