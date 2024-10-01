using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class jaggedArray
    {
        public  static void Main()
        {
            string[][] Qual = new string[3][];
            Qual[0] = new string[2] { "SSC", "Inter" };//done
            Qual[1] = new string[3] { "SSC", "Inter","Btech" };
            Qual[2] = new string[4] { "SSC", "Inter","Btech","Mtech" };

            for (int i = 0; i < Qual.Length; i++)//Entering into floor
            {
                for (int j = 0; j < Qual[i].Length; j++)//enter room
                {
                    Console.Write(Qual[i][j]+" ");
                }
            }

            Console.ReadLine();
        }
    }
}
