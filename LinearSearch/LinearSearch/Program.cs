using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int UserInput = Convert.ToInt32(Console.ReadLine());
            bool status = true;

            for (int i = 0; i < Numbers.Length; i++)
            {
             
                if (Numbers[i] == UserInput)
                {
                    Console.WriteLine(UserInput + " Item Is Found");
                    status = true;
                    break;
                }
                status = false;
            }
            if (status == false)
            {
                Console.WriteLine(UserInput + " Item Was Not Found");
            }
            Console.ReadKey();
        }
    }
}
