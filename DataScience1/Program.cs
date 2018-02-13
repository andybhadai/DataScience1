using System;
using System.Collections.Generic;

namespace DataScience1
{
    public class Dictionary<TKey, TValue>
    {
        public List<KeyValuePair<TKey, TValue>> List = new List<KeyValuePair<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            KeyValuePair<TKey, TValue> kvp = new KeyValuePair<TKey, TValue>(key, value);
            this.List.Add(kvp);
        }
    }

    public class KeyValuePair<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;

        public KeyValuePair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Mark", "Romy");
            dictionary.Add("Mark", "Jason");
            dictionary.Add("Mark", "Documentation Dilan");
            dictionary.Add("Mark", "Mark");
            Console.ReadLine();
        }
    }
}
