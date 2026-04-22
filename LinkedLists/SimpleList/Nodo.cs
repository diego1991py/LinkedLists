namespace SimpleList
{
    public class Nodo<T>
    {
        public Nodo(T data)
        {
            Data = data;
            Next = null;
        }
        public T? Data { get; set; }
        public Nodo<T>? Next { get; set; }
    }
}
