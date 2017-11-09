using System;
using System.Collections.Generic;

namespace QueueLibrary
{
    public sealed class QueueWrapper<T>
    {
        private T _currentItem;
        private readonly Queue<T> CurrentQueue = new Queue<T>();
        private readonly object LockObj = new object();
        private static readonly Lazy<QueueWrapper<T>> instance = new Lazy<QueueWrapper<T>>(() => new QueueWrapper<T>());

        private QueueWrapper()
        {
        }

        public static QueueWrapper<T> Instanse => instance.Value;

        /// <summary>
        /// Append To Queue
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            lock (LockObj)
            {
                CurrentQueue.Enqueue(item);
            }
        }

        /// <summary>
        /// Get From Queue
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (CurrentQueue.Count > 0)
            {
                lock (LockObj)
                {
                    if (CurrentQueue.Count >= 0)
                    {
                        _currentItem = CurrentQueue.Dequeue();
                        return _currentItem;
                    }
                }
            }
            return default(T);
        }
    }
}
