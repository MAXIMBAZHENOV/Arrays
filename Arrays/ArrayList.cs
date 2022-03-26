using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArrayList<T>
    {
        private T[] _storage;
        private int _lastItemIndex;

        public ArrayList()
        {
            _storage = new T[4];
            _lastItemIndex = -1;
        }

        public void Add(T item)
        {
            if(_lastItemIndex == _storage.Length -1)
            {
                ExpandStorage();
            }

            _lastItemIndex++;
            _storage[_lastItemIndex] = item;

        }
        
        public void Insert(int index, T item)
        {
            ValidateIndex(index);
             
            if(_lastItemIndex == _storage.Length -1)
            {
                ExpandStorage();
            }

            int segmentLength = _lastItemIndex - index + 1;

            Array.Copy(_storage, index, _storage, index + 1,segmentLength);

            _lastItemIndex++;
            _storage[index] = item; 
        }

        public int Length => _lastItemIndex + 1;

        public int StorageLength => _storage.Length;

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return _storage[index];
            }
            set 
            {
                ValidateIndex(index);
                _storage[index] = value;
            }

        }
        private void ValidateIndex(int index)
        {
            if (index > _lastItemIndex || index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));
        }

        private void ExpandStorage()
        {
            var newStorage = new T[_storage.Length * 2];
            Array.Copy(_storage,newStorage,_storage.Length);
            _storage = newStorage;
        }
    }
}
