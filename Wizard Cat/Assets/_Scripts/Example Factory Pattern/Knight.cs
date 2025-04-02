using System;
using UnityEngine;

public class Knight : MonoBehaviour
{
    [SerializeField] private EquipmentFactory _equipmentFactory;
    [SerializeField] private WeaponFactory _weaponFactory;
    [SerializeField] private ShieldFactrory _shieldFactory;
    private IWeapon _weapon = IWeapon.CreateDefault();

    private void Start() {
        if (_weaponFactory != null) {
            _weapon = _weaponFactory.CreateWeapon();
        }

        Attack();
    }

    public void Attack() => _weapon?.Attack();
}