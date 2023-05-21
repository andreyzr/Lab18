using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list =new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int[] array = new int[3] { 4, 5, 6 };
            list.AddRange(array);
            list.RemoveAt(3);
            foreach (var i in list)
            {
                Console.WriteLine(  i);
            }
            Console.ReadKey();

             
        }
    }
}
