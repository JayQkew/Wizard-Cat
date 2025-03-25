using UnityEngine;

/// <summary>
/// a subclass that creates bow objects
/// </summary>
[CreateAssetMenu(fileName = "BowFactory", menuName = "Weapon Factory/Bow")]
public class BowFactory : WeaponFactory
{
    public override IWeapon CreateWeapon()
    {
        return new Bow();
    }
}