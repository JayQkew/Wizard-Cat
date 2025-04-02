using UnityEngine;

[CreateAssetMenu(fileName = "GenericShieldFactory", menuName = "Generic Shield Factory")]
public class GenericShieldFactory : ShieldFactrory
{
    public override IShield CreateShield() {
        return new Shield();
    }
}