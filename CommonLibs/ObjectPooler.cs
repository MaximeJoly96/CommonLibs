using System.Collections.Generic;

namespace CommonLibs
{
    public class ObjectPooler<T> where T : new()
    {
        private static readonly Queue<T> _pool = new Queue<T>();

        public T GetElement()
        {
            T element = _pool.Count > 0 ? RetrieveFromPool() : GetNewElement();
            return element;
        }

        private T GetNewElement()
        {
            T element = new T();
            _pool.Enqueue(element);
            return element;
        }

        private T RetrieveFromPool()
        {
            T element = _pool.Count > 0 ? _pool.Dequeue() : new T();
            return element;
        }
    }
}
