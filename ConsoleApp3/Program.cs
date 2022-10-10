using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine (countdown(0));
        }

        public static string countdown(int total)
        {
            string count = "";
            while (total >= 0)
            {
                count += total;
                count += " ";
                total = total - 1;

            }
            count = count.Remove(count.Length - 1, 1);

            return count;
        }
    }
}
// place your function here
