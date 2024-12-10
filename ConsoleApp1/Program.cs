using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Удалить все четные элементы из массива и в новом массиве сложить
            int[] omas = { 3, 7, 1, 9, 5, 6, 8, 10 };
            omas = omas.Where(x => x % 2 != 0).ToArray();  
            foreach(var x in omas)
            {
                Console.WriteLine(x);
            }
            int sum = omas.Sum();
            Console.WriteLine(sum);
            Console.ReadKey();
            
        }
    }
}
