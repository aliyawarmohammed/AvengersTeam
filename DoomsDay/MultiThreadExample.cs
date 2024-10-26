using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoomsDay
{
    internal class MultiThreadExample
    {

        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Thread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }


    }


    class ThreadExample
    {
        public static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(MultiThreadExample.Thread1));
            t1.Start();
            t1.Suspend();//Thread.Sleep(4000);

            Thread t2 = new Thread(new ThreadStart(MultiThreadExample.Thread2));
            t2.Start();

            Console.ReadLine();

        }


    }
}
