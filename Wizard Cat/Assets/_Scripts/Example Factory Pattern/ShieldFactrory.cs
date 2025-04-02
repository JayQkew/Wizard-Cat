using UnityEngine;

public abstract class ShieldFactrory : ScriptableObject
{
    public abstract IShield CreateShield();
}

public interface IShield
{
    void Defend();

    static IShield CreateDefault() {
        return new Shield();
    }
}

public class Shield : IShield
{
    public void Defend() {
        Debug.Log("Shield Defend");
    }
}