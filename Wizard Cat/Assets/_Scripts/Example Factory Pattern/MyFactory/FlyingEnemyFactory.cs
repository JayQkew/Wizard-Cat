using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FlyingEnemyFactory", menuName = "Enemy Factory/Flying")]
public class FlyingEnemyFactory : EnemyFactory
{
    public FlyingEnemies enemyType;
    public override IEnemy CreateEnemy()
    {
        switch (enemyType)
        {
            case FlyingEnemies.Bat:
                return new Bat();
            case FlyingEnemies.Eyeball:
                return new Eyeball();
            default:
                return null;
        }
    }

    public enum FlyingEnemies
    {
        Bat,
        Eyeball
    }
}
