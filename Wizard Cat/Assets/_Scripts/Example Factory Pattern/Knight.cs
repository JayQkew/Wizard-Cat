using System;
using UnityEngine;

public class Knight : MonoBehaviour
{
    [SerializeField] private WeaponFactory _weaponFactory;
    private IWeapon _weapon = IWeapon.CreateDefault();

    private void Start()
    {
        if (_weaponFactory != null)
        {
            _weapon = _weaponFactory.CreateWeapon();
        }
        
        _weapon.Attack();
    }

    public void Attack() => _weapon?.Attack();
}