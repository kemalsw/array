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
            int[] sayididizisi = { 23, 35, 9, 85, 3, 8, 15 };
            Array.Sort(sayididizisi);
            foreach (var i in sayididizisi)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
