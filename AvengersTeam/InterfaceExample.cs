using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal interface InterfaceExample
    {
          int Add(int a, int b);
        int sub(int a, int b);

    }

    public class ImplementInterFace : InterfaceExample
    {
        public int Add(int a, int b)
        {
            return a + b; ;
        }

        public int sub(int a, int b)
        {
            return a-b; ;
        }

        public static void Main()
        {
            ImplementInterFace imp = new ImplementInterFace();

            Console.WriteLine(imp.Add(20, 40));

            Console.WriteLine(imp.sub(20, 40));


            Console.ReadLine();
        }
    }

}


//Abstract Class

//A class is called abstract class which have both abstract method and
//non abstract method

//what do you mean by abstract method?
//Abstract method mean incomplete method. just having declaration without body
//A method without body is called as Abstract method


//What is Non Abstract Method?
//A Method which have body its called as Non Abstract Method

//How to Define Abstract Class and Abstract?
//using Abstract Keyord

//Can we Create an Instance of Abstract Class ?
//Ans:no as it is an Incomplete Class




//Interface: are pure abstract mehod.no need to write abstract keyword for them

//interface all methods are by default public

//you cannot create object for it

//if class want to use Interface then that class need to implement that interface

//you can reference interface
//you can implement multiple inheritance using interface

