using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class MyDictionary<K,V>
    {
        public MyDictionary()
        {
            _keyArray = Array.Empty<K>();
            _valueArray = Array.Empty<V>();
        }
        private K[] _keyArray;
        private V[] _valueArray;

        public int Count
        {
            get { return _valueArray.Length; }
        }

        public K[] Keys
        {
            get { return _keyArray; }
        }
        
        public V this[K index]
        {
            get
            {
                return _valueArray[FindIndex(_keyArray,index)];
            }
            set
            {
                _valueArray[FindIndex(_keyArray,index)] = value;
            }
        }
        
        public void Add(K key, V value)
        {
            Array.Resize(ref _keyArray, _keyArray.Length + 1);
            _keyArray[_keyArray.Length - 1] = key; 
            Array.Resize(ref _valueArray, _valueArray.Length + 1);
            _valueArray[_valueArray.Length - 1] = value;
        }

        private int FindIndex<T>(Array array,T element)
        {
            int count = 0;
            foreach (var i in array)
            {
                if (!Equals(i, element))
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
