using System;

namespace TaoOnehacker.DataStructure.Application
{
    public class Array
    {
        private int[] data;
        private int size;

        public Array(int capacity)
        {
            data = new int[capacity];
            size = 0;
        }

        public Array():this(10)
        {
        }

        public int GetCapacity()
        {
            return data.Length;
        }

        public int GetSize()
        {
            return size;
        }

        public void Add(int index, int e)
        {
            if(index==data.Length)
                throw new ArgumentException("Add failed. Array is full.");
            
            if(index<0||index>size)
                throw  new ArgumentException("Add failed. Required index >=0 and index<= size.");

            for (var i = size-1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }

            data[index] = e;
            
            size++;
        }

        public void AddFirst(int e)
        {
            Add(0,e);
        }

        public void AddLast(int e)
        {
            Add(size,e);
        }
        
        
        
    }
}