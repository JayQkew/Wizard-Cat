public class GenericShieldFactory : ShieldFactrory
{
    public override IShield CreateShield() {
        return new Shield();
    }
}