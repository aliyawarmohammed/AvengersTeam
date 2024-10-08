using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class Inheritance_1
    {

        public void show()
        {
            Console.WriteLine("Inh_1 Show Method is called");

        }
    }

    internal class Inheritance_2 : Inheritance_1
    {



    }

    internal class Inheritance_3: Inheritance_1
    {
       

    }


    internal class Inheritance_4 
    {
        public static void Main()
        {
            Inheritance_3 obj = new Inheritance_3();
            obj.show();
            Console.ReadLine();
        }
    }
}


//the process of deriving a new class from old class is called as inheritance





// class Amitabh
//{
//-------------
//}

//class abhishek : Amitabh //abhishek class is called as new class from an old clas(abhishek)
//{
//--------
//}



//we have difference type of inheritance

//1)single level
//if you have one parent class and one child class is called as single level inheritance


//2)multi level 

//A=>B=>C=>D



//3)multiple level 

//Two Parents one child it is called Multiple level Inheritance
//class C : A, B
//{
//}

//Multiple level inheritance not supported using class in C#
//using Interface it is supported








