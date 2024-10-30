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
            Thread t = Thread.CurrentThread;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(t.Name+" running "+i);
            }
        }

        public static void Thread2()
        {
            Thread t = Thread.CurrentThread;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(t.Name + " running " + i);
            }
        }

        public static void Thread3()
        {
            Thread t = Thread.CurrentThread;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(t.Name + " running " + i);
            }
        }



    }


    class ThreadExample
    {
        public static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main thread";
            Console.WriteLine(t.Name+" is running thread");






            Thread t1 = new Thread(new ThreadStart(MultiThreadExample.Thread1));
            Thread t2 = new Thread(new ThreadStart(MultiThreadExample.Thread2));
            Thread t3 = new Thread(new ThreadStart(MultiThreadExample.Thread3));

            t1.Name = "printing english paper";
            t2.Name = "printing hindi paper";
            t3.Name = "printing telgue paper";


            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Normal;
            t3.Priority = ThreadPriority.Highest;


            t1.Start();
            t2.Start();
            t3.Start();


            // t1.Suspend();//Thread.Sleep(4000);
            //t1.Join();//join method will not allow another thread to execute untill t1 complete execution






          

            //Thread.Sleep(4000);
            // t1.Resume();
            //t2.Abort();
            Console.ReadLine();

        }


    }
}
