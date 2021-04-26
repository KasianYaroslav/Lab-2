using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class MyList<T>
    {
        public MyList()
        {
            _array = Array.Empty<T>();
        }
        private T[] _array;
        public T this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        public int Count
        {
            get => _array.Length;
        }

        public void Add(T value)
        {
            Array.Resize(ref _array, _array.Length + 1);
            _array[_array.Length-1] = value;
        }
    }
}
