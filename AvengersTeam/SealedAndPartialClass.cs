using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AvengersTeam
{
    internal sealed class SealedAndPartialClass
    {
       public void show()
        {
            Console.WriteLine("I have done home work");
        }
    }

    internal class SealedAndPartialClass2 //:SealedAndPartialClass
    {
        public static void Main()
        {
            SealedAndPartialClass obj = new SealedAndPartialClass();
            obj.show();
            Console.ReadLine();
    }
    }

}



//Compile time polymorphism
//run time polymorphism
//Sealed class
//Partial Class


//4 pillars oops

//1)encapsulation
//2)inheritance
//3)Polymorphism: greek word
//4)abstraction



//poly -many
//morphism- behaviour


//an error which is going to be find out at  the time of compilation is called as compile time error and it can happen if code is compiled at compile time


//after running application if u get an error that
//error are called as run time polymorphism





//void add(int a, int b)
//void add(int a, int b,int c)

//same method name
//different paramter
//different arrangment of arguments

//it is called as method overloading
//you need to call explicitly


//2 types

//compile time:overloading
//runtime :overriding





//class A
//{
//    logic
//    code
//method1()
//    {
//        not earning
//}

//}


//class B : A
//{

//    method1()
//    {
//        earning
//    }
//}


//1)inheritance
//2)child class method name and its parameter, should be same as parent class
//3)overriding parent class method inside child class

//rules :
//        parent class you should write 'virtual' keyword
//        child class you should write 'override' keyword

//Virtual keyword for parent class method
//override keyword for child class

//virtual keyword methods cannot be private

//Sealed Class Concept:

//a class which is declared as sealed is called as Sealed class
//sealed is keyword

//any class which cannot be futher inherited it is called as Sealed class


//sealed class Amitabh
//{
//-------------
//}

//class manish : Amitabh
//{
//--------
//}


//Partial Class :


//if multiple people want to work on same class simentaniously
//at that time we can  make that class as partial class


//partial class ShoppingCart
//{

//    AddCart()


//}



//partial class ShoppingCart
//{

//    removeCart()


//}


//partial class ShoppingCart
//{

//    UpdateCart()


//}




























