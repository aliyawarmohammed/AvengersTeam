using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DoomsDay
{
    internal class DictionaryExaple
    {

        public static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Radha");
            dict.Add(2, "Adha");
            dict.Add(3, "zada");


            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + "," + item.Value);
            }

            Console.ReadLine();

        }
    }
}
