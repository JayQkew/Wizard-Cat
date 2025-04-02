using UnityEngine;

public class EquipmentFactory : ScriptableObject
{
    public WeaponFactory weaponFactory;
    public ShieldFactrory shieldFactory;

    public IWeapon CreateWeapon() {
        if (weaponFactory != null) {
            return weaponFactory.CreateWeapon();
        }

        return IWeapon.CreateDefault();
    }
}