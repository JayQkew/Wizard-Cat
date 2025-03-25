using UnityEngine;

public abstract class EnemyFactory : ScriptableObject
{
    public abstract IEnemy CreateEnemy();
}

public interface IEnemy
{
    void Attack();
    void Move();
    void OnDeath();

    static IEnemy CreateDefault()
    {
        return new Goblin();
    }
}

public class Goblin : IEnemy
{
    public void Attack()
    {
        Debug.Log("Goblin Throwing Rocks!");
    }

    public void Move()
    {
        Debug.Log("Goblin Hobbling!");
    }

    public void OnDeath()
    {
        Debug.Log("Goblin Slayn!");
    }
}

public class Spider : IEnemy
{
    public void Attack()
    {
        Debug.Log("Spider Borne Fangs!");
    }

    public void Move()
    {
        Debug.Log("Spider Crawling!");
    }

    public void OnDeath()
    {
        Debug.Log("Spider Squashed!");
    }
}

public class Bat : IEnemy
{
    public void Attack()
    {
        Debug.Log("Bat Diving You!");
    }

    public void Move()
    {
        Debug.Log("Bat Fluttering!");
    }

    public void OnDeath()
    {
        Debug.Log("Bat Swotted!");
    }
}

public class Eyeball : IEnemy
{
    public void Attack()
    {
        Debug.Log("Eyeball Dashing at You!!");
    }

    public void Move()
    {
        Debug.Log("Eyeball Floating!");
    }

    public void OnDeath()
    {
        Debug.Log("Eyeball Splattered!");
    }
}