using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> month = new Dictionary<string,int>();
            month.Add("jan", 31);
            month.Add("feb", 28);
            month.Add("mar", 31);
            month.Add("apr", 30);
            month.Add("may", 31);
            month.Add("jun", 30);
            month.Add("jul", 31);
            month.Add("aug", 31);
            month.Add("sep", 30);
            month.Add("oct", 31);
            month.Add("nev", 30);
            month.Add("dec", 31);
            Console.WriteLine(month["may"]);
            Console.ReadKey();
        }
    }
}
