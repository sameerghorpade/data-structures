using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Structure.Arrays
{
    public class DynamicArray:IDynamicArray
    {
        int[] items = new int[5];
        int count = 0;

        public DynamicArray()
        {
            
        }

        //insert
        public void Insert(int value)
        {

            items[count++] = value;
            
            
        }

        //delete
        public void Delete(int value)
        {

        }

        //Contains
        public bool Contains(int value)
        {
            return false;
        }

        //indexOf
        public int IndexOf(int value)
        {
            return -1;
        }

        //Largest number.
        public int Max()
        {
            return -1;
        }

        //return the common items in this array and another array
        public int[] CommonItems(int[] values)
        {
            return null;
        }

        //Array.reverse
        public int[] Reverse()
        {
            return null;
        }

        //Insert an item at a given index
        public void InsertAt(int index)
        {

        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
