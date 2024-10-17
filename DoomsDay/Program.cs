using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomsDay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList myvar = new ArrayList();
            myvar.Add(12);
            myvar.Add("Devi");
            myvar.Add(true);

            //foreach (var item in myvar)
            //{
            //    Console.WriteLine("Values are:"+item);
            //}

            //  Console.WriteLine("Values are:" + myvar[0]);
            //myvar.RemoveAt(2);
            //myvar.Remove(12);
            // myvar.Reverse();
            myvar.Insert(1, "Player");
            foreach (var item in myvar)
            {
                Console.WriteLine("Values are:" + item);
            }
            Console.ReadLine();
        }
    }
}
