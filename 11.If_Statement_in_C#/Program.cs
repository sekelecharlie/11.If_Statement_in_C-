using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_Statement_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;

            if (!isMale)
            {
                Console.WriteLine("Female");
            }
            else
            {
                Console.WriteLine("Male");
            }
            bool isTall = false;
            if (!isTall && isMale )
            {
                Console.WriteLine("You are both female and tall ");
            }
            else if (!isTall && !isMale )
            {
                Console.WriteLine("you are neigther a male tall ");
            }

            Console.Read();

        }
    }
}
