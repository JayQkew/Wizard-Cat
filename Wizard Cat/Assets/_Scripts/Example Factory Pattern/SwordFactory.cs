using UnityEngine;

/// <summary>
/// A subclass that creates Sword objects
/// </summary>
[CreateAssetMenu(fileName = "SwordFactory", menuName = "Weapon Factory/Sword")]
public class SwordFactory : WeaponFactory
{
    public override IWeapon CreateWeapon()
    {
        return new Sword();
    }
}