namespace ObjectPool
{
    public interface ICreation<T>
    {
        T Create();
    }
}