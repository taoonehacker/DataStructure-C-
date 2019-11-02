using System;

namespace TaoOnehacker.DataStructure.Application
{
    public class Array
    {
        private readonly int[] _data;
        private int _size;

        public Array(int capacity)
        {
            _data = new int[capacity];
            _size = 0;
        }

        public Array():this(10){}

        public int GetCapacity()
        {
            return _data.Length;
        }

        public int GetSize()
        {
            return _size;
        }

        public void Add(int index, int e)
        {
            if(index==_data.Length)
                throw new ArgumentException("Add failed. Array is full.");
            
            if(index<0||index>_size)
                throw  new ArgumentException("Add failed. Required Index >=0 and Index<= size.");

            for (var i = _size-1; i >= index; i--){
                _data[i + 1] = _data[i];
            }
            
            _data[index] = e;
            _size++;
        }

        public void AddFirst(int e)
        {
            Add(0,e);
        }

        public void AddLast(int e)
        {
            Add(_size,e);
        }

        public int Get(int index)
        {
            if(index<0||index>_size)
                throw new ArgumentException("Get failed. Index is illegal.");
            return _data[index];
        }

        public void Set(int index, int e)
        {
            if(index<0||index>_size)
                throw new ArgumentException("Get failed.Index is illegal.");
            _data[index] = e;
        }

        public bool Contains(int e)
        {
            for (var i = 0; i < _size; i++)
                return _data[i] == e;

            return false;
        }

        public int Find(int e)
        {
            for (var i = 0; i < _size; i++)
                if (_data[i] == e)
                    return i;
            return -1;
        }

        public int Remove(int index)
        {
            if(index<0||index>_size)
                throw new ArgumentException("Get failed.Index is illegal.");

            var res = _data[index];
            for(var i=index+1;i<_size;i++)
            {
                _data[i-1] = _data[i];
            }
            _size--;
            return res;
        }

        public int RemoveFirst()
        {
            return Remove(0);
        }

        public int RemoveLast()
        {
            return Remove(_size-1);
        }


        public void RemoveElement(int e)
        {
            var index = Find(e);
            if (index > 0)
                Remove(index);
        }
    }
}