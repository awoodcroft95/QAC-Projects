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
            e.find("I am, going, am, to London", "am");
            Console.Read();
        }
    }

    class English
    {
        public void words(string na)
        {
            string[] words = na.Split(' ');
            Console.WriteLine(words.Length);
        }

        public void find(string message, string findWhat)
        {
            int substringLength = findWhat.Length;
            int foundCount=0;
            for (int i = 0; i < message.Length - substringLength; i++)
            {
                if (message.Substring(i, substringLength) == findWhat)
                {
                    foundCount++;
                }
            }
            Console.WriteLine(foundCount);
        }
    }
}
