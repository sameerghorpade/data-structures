using Sameer.DS.CustomLib.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sameer.DS.CustomLib
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vs = new List<int>();
            

            Console.WriteLine("Array Example");
            Console.WriteLine("-------------");
            IDynamicArray ds = new DynamicArray();
            ds.Insert(10);
            ds.Insert(20);
            ds.Insert(30);
            ds.Insert(40);
            ds.Insert(50);
            ds.Insert(60);
            ds.Insert(70);
            ds.Insert(80);
            ds.Insert(90);
            

            ds.InsertAt(2, 900);
            var m = ds.Max();
            var ra = ds.Reverse();
            var ci = ds.CommonItems(new int[] { 10, 900, 66, 29, 50 });
            Console.WriteLine("Max: " + m);
            ds.Print();
        }
    }
}
