using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomsDay
{
    internal class ListExample
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);


            list.Remove(1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(list[1]);
            
            Console.ReadLine();
        }
    }
}
