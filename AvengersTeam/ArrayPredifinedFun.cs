using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class ArrayPredifinedFun
    {
        public static void Main()
        {
            int[] arr = new int[4] { 1, 2, 3, 4 };
            int[] brr = new int[4];

            arr.CopyTo(brr, 0);
            //Console.WriteLine(arr.Rank);

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine("after sorting");

            Array.Sort(arr);
            //Console.WriteLine();

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();

            //Console.WriteLine("after reverse");

            //Array.Reverse(arr);

            //Console.WriteLine();

            foreach (var item in brr)
            {
                Console.Write(item+",");
            }



            Console.ReadLine();
        }
    }
}
