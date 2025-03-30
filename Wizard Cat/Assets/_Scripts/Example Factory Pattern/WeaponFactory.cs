using UnityEngine;

/// <summary>
/// A superclass that manages the creation of all weapons
/// </summary>
public abstract class WeaponFactory : ScriptableObject
{
    /// <summary>
    /// used by subclasses to create a weapon
    /// </summary>
    /// <returns>an object with IWeapon interface</returns>
    public abstract IWeapon CreateWeapon();
}

// this is a common relation that all the products have
// in this case it is being a weapon
public interface IWeapon
{
    void Attack();

    //only exists on this interface
    //static function belongs to the type ITSELF
    static IWeapon CreateDefault()
    {
        return new Sword();
    }
}

//Sword **Product** class
public class Sword : IWeapon
{
    public void Attack()
    {
        Debug.Log("Swinging the sword!");
    }
}

//Bow **Product** class
public class Bow : IWeapon
{
    public void Attack()
    {
        Debug.Log("Shooting the bow!");
    }
}