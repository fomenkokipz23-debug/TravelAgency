using System;
using System.Collections.Generic;

namespace TravelAgency.Domain
{
    public class Repository<T> where T : class
    {
        protected readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            _items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public void ForEach(Action<T> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            
            foreach (var item in _items)
            {
                action(item);
            }
        }

        public List<T> Filter(Func<T, bool> predicate)
        {
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            List<T> result = new List<T>();
            foreach (var item in _items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}