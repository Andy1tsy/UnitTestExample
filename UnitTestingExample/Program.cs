using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            string t1 = "qwertyuio";
            string t2 = "12345678";
            string res = StringMethods.MixStrings(t1, t2);
            Console.WriteLine(res);

            Console.ReadLine();
        }

       

    }
}
