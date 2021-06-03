using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sameer.DS.CustomLib.Arrays
{

    public class DynamicArray : IDynamicArray
    {
        private int[] items { get; set; }
        private int Count { get; set; }
        public DynamicArray()
        {
            items = new int[5];
            Count = 0;
        }
        public int[] CommonItems(int[] values)
        {
            int[] commonItems = new int[items.Length];
            int index = 0;
            foreach (var item in values)
            {
                foreach (var num in items)
                {
                    if(item == num)
                    {
                        commonItems[index++] = item;
                    }
                }
            }
            return commonItems;
        }

        public bool Contains(int value)
        {
            if (Count > 0)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] == value) return true;
                }
            }
            return false;
        }

        public void Delete(int value)
        {
            if (Count > 0)
            {
                if (items[Count] == value)
                {
                    items[Count] = 0;
                    return;
                }
                else
                {
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (items[i] == value)
                        {
                            items[i] = items[i + 1];
                        }
                    }
                }    
            }
        }

        public int IndexOf(int value)
        {
            if (Count > 0)
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i] == value) return i;
                }
            return -1;
        }

        public void Insert(int value)
        {
            if (Count < items.Length)
                items[Count++] = value;
            else
            {
                IncreaseSize();
                items[Count++] = value;
            }
        }

        private void IncreaseSize()
        {
            int[] newItems = new int[Count * 2];
            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }

        public void InsertAt(int index, int value)
        {
            if (items[items.Length - 1] != 0) IncreaseSize();
            
            if (Count < items.Length && index <= Count)
            {
                int currItem = items[index];
                items[index] = value;

                for (int i = index+1; i <= Count; i++)
                {
                    int nextValue = items[i];
                    items[i] = currItem;
                    currItem = nextValue;
                }
            }
           
        }

        public int Max()
        {
            if(Count > 0)
            {
                int max = items[0];
                for (int i = 1; i < items.Length-1; i++)
                {
                    if (items[i] > max)
                        max = items[i];
                }
                return max;
            }
            return -1;
        }

        public void Print()
        {
            for (int i = 0; i <= Count; i++)
            {
                Console.Write(items[i] + "\n");
            }
            Console.Read();
        }

        public int[] Reverse()
        {
            if (Count > 0)
            {
                int[] reverseItems = new int[items.Length];
                int index = 0;
                for (int i = items.Length - 1; i >= 0; i--)
                {
                    reverseItems[index] = items[i];
                    index++;
                }
                items = reverseItems;
            }
            return items;
        }
    }
}
