using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomsDay
{
    internal class HashTableExample
    {
        public static void Main()
        {
            Hashtable ht=  new Hashtable();
            ht.Add(1, "Radha");
            ht.Add(2, "Rajiv");
            ht.Add(3, "sumetha");
            ht.Add(4, "shekhar");

            foreach(var key in ht.Keys) {

                Console.WriteLine(ht[key]);
            
            }

            Console.ReadLine();
        }

    }
}
