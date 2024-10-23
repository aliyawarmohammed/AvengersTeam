using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomsDay
{
    internal class Custom_Exceptions:Exception
    {
        public Custom_Exceptions(string message):base(message) { }
        
    }

    public class Custom_ExceptionExample { 
    
    public void doSomething()
        {

            int ageErrorOccureOcured = 17;
            if(ageErrorOccureOcured<18)
            {
                throw new Custom_Exceptions("age exception");
            }
        }

        public static void Main()
        {
            Custom_ExceptionExample d = new Custom_ExceptionExample();
            try
            {
                d.doSomething();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message+","+e.StackTrace);
            }
           

            finally { Console.WriteLine("Exception came exception Class++"); }
            Console.ReadLine();

        }    
    
    }
}
