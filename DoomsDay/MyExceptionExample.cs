using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomsDay
{
    internal class MyExceptionExample
    {

        public static void Main()
        {
            try
            {
                int num = 0;

                int c = num / 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("hi");
            }
            Console.ReadLine();

        }
    }
}
