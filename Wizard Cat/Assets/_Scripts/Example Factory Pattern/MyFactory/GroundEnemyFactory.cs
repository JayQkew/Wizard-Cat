using System;
using UnityEngine;

[CreateAssetMenu(fileName = "GroundEnemyFactory", menuName = "Enemy Factory/Ground")]
public class GroundEnemyFactory : EnemyFactory
{
    public GroundEnemies enemyType;
    public override IEnemy CreateEnemy()
    {
        switch (enemyType)
        {
            case GroundEnemies.Goblin:
                return new Goblin();
            case GroundEnemies.Spider:
                return new Spider();
            default:
                return null;
        }
    }

    public enum GroundEnemies
    {
        Goblin,
        Spider
    }
}
