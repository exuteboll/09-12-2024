using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demidov
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
                int[] fruit = { 4, 3, 6, 7 };
                Array.Sort(fruit);
            foreach(int i in fruit)
            {
                Console.WriteLine(i);
            }
                
                Array.Reverse(fruit);
            foreach (int i in fruit)
            {
                Console.WriteLine(i);
            }
            
                Console.ReadKey();
            
        }
    }
}
