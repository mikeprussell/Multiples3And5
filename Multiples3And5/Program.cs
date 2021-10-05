using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        //This program returns the sum of all numbers 
        //that are multiples of 3 or 5 that are below 1,000.

        static void Main(string[] args)
        {
            //variable tracks sum
            int total = 0;

            for (int i = 0; i < 1000; i++)
            {
                //if statement adds to sum when the remainder is 0 
                //when divided by 3 or 5 (or condition removes duplicates)
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    total = total + i;
                }
            }

            Console.WriteLine(total);

        }

    }//End of class

}//End of namespace
