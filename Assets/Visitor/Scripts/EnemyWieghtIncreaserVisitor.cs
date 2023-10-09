using UnityEngine;

public class EnemyWieghtIncreaserVisitor : IEnemyVisitor
{
    public int Value { get; private set; }
    public void Visit(Human human)
    {
        Value += 10;
    }

    public void Visit(Ork ork)
    {
        Value += 15;
    }

    public void Visit(Elf elf)
    {
        Value += 20;
    }
}