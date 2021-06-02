using Data.Structure.Arrays;
using System;

namespace Data.Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            IDynamicArray ds = new DynamicArray();
            ds.Insert(10);
            ds.Print();

        }
    }
}
