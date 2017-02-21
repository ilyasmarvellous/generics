using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>(7);
            d.Add(1, "Ilyas");
            d.Add(2, "Teja");
            d.Add(3, "Umakanth");
            d.Add(4, "Rajeesh");
            d.Add(5, "Rohan");
            d.Add(6, "Bharat");
            d.Add(7, "Venu");
            for (int i = 1; i <= d.Count; i++)
            {
                Console.WriteLine(d[i]);
            }
            Console.ReadKey();
        }
    }
}
