using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number for a times table: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, num, i * num);
            
            }



            Console.ReadLine();
        }
    }
}
