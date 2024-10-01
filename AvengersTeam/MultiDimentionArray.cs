using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class MultiDimentionArray
    {

        public static void Main()
        {
            int[] trr = {1,5,3,4};
            int[] trr12 = new int[4];
            int[,] arr = new int[2, 2] { {1,2 },{3,4} };

            //foreach (int i in arr) { 
            //Console.Write(i);

            //}

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.ReadLine();

            }






            Console.ReadLine();
        
        }
    }
}
