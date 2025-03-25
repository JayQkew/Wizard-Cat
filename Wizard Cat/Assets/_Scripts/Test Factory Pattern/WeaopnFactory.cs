using UnityEngine;

public interface IWeapon
{
    void Attack();

    static IWeapon CreateDefault()
    {
        return new Sword();
    }
}

public class Sword : IWeapon
{
    public void Attack()
    {
        Debug.Log("Swinging the sword!");
    }
}

public class Bow : IWeapon
{
    public void Attack()
    {
        Debug.Log("Shooting the bow!");
    }
}