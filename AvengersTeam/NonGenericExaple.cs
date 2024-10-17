using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class NonGenericExaple
    {
        public static void Main()
        {
            ArrayList myvar = new ArrayList();
            myvar.Add(12);
            myvar.Add("Devi");
            myvar.Add(true);

            //foreach (var item in myvar)
            //{
            //    Console.WriteLine("Values are:"+item);
            //}
            
            Console.WriteLine("Values are:" + myvar[0]);

            Console.ReadLine();
        }

    }
}



//Collections: used to large amount of data in a single variable 


//devided 2 types

//1)non generic :arrayList, Hashtable, Stack, Queue can store different datatype
//if you want to hold multiple values of different datatype use non generic

//ArrayList
//HashTable
//Stack
//Queue



//2) generic collection:same Datatype, type Safety


