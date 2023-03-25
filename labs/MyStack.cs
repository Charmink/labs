namespace labs;

public class MyStack<T> : IQueue<T>
{
    private Stack<T> stack = new Stack<T>();

    public void Enqueue(T item)
    {
        stack.Push(item);
    }

    public T Dequeue()
    {
        return stack.Pop();
    }

    public int Count => stack.Count;
}