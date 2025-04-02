using UnityEngine;

[CreateAssetMenu(fileName = "EquipmentFactory", menuName = "Equipment Factory")]
public class EquipmentFactory : ScriptableObject
{
    public WeaponFactory weaponFactory;
    public ShieldFactrory shieldFactory;

    public IWeapon CreateWeapon() {
        return weaponFactory != null ? weaponFactory.CreateWeapon() : IWeapon.CreateDefault();
    }

    public IShield CreateShield() {
        return shieldFactory != null ? shieldFactory.CreateShield() : IShield.CreateDefault();
    }
}