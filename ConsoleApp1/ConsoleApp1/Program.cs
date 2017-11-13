using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            one T = new one();
            T.mesage();
            Console.Read();
        }
    }

    class one
    {
        public void mesage()
        {
            Console.Write("Hello my friends");
        }
    }
}
