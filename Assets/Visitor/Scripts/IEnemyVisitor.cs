public interface IEnemyVisitor
{
    public void Visit(Human human);
    public void Visit(Ork ork);
    public void Visit(Elf elf);
}