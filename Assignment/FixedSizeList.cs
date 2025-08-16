using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {
        public T[] Items { get; set; }
        public int Capacity {  get; set; }
        public int CurrentSize {  get; set; }

        public FixedSizeList(int _capacity)
        {
            if (_capacity <= 1)
            {
                throw new ArgumentOutOfRangeException("Capacity must be grater than  1 ");
            }

            Capacity = _capacity;

           Items = new T[_capacity];

            CurrentSize = 0;
            
        }

        private bool IsFull()
        {
            return CurrentSize >= Capacity; 
        }


        public void Add( T value)
        {
            if (IsFull())
            {
                throw new ArgumentException("the list is Full ");

            }
            Items[CurrentSize] = value;
            CurrentSize++;
        }

        public T GetIndex(int index) { 
        
            if(index <0  || index >CurrentSize)
                throw new ArgumentOutOfRangeException("index");

            return Items[index];
        
        
        }
    }
}
