using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced01
{
    internal class Cache<TKey, TValue>
    {
        private class CacheItem
        {
            public TValue Value { get; set; }
            public DateTime ExpirationTime { get; set; }
        }

        private readonly Dictionary<TKey, CacheItem> items = new();

        public void Add(TKey key, TValue value, TimeSpan expiration)
        {
            items[key] = new CacheItem
            {
                Value = value,
                ExpirationTime = DateTime.Now.Add(expiration)
            };
        }

        public TValue Get(TKey key)
        {
            if (!items.ContainsKey(key))
                return default;

            CacheItem item = items[key];

            if (DateTime.Now >= item.ExpirationTime)
            {
                items.Remove(key);
                return default;
            }

            return item.Value;
        }

        public bool Remove(TKey key)
        {
            return items.Remove(key);
        }

        public bool Contains(TKey key)
        {
            if (!items.ContainsKey(key))
                return false;

            if (DateTime.Now >= items[key].ExpirationTime)
            {
                items.Remove(key);
                return false;
            }

            return true;
        }
    }
}
