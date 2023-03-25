using labs;

public class MyQueue<T> : IQueue<T>
{
    private Queue<T> queue = new Queue<T>();

    public void Enqueue(T item)
    {
        queue.Enqueue(item);
    }

    public T Dequeue()
    {
        return queue.Dequeue();
    }

    public int Count => queue.Count;
}