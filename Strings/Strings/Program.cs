using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            English e = new English();
            e.words("I am in QA");
            Console.Read();
        }
    }

    class English
    {
        public void words(string na)
        {
            string[] words = na.Split(' ');
            Console.Write(words.Length);
        }
    }
}
