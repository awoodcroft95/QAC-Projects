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
            e.find("I am london going to london", "london");
            e.verticalSentence("I am going to QA");
            e.reverseVert("I am going to the Moon");
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
            int foundCount = 0;
            for (int i = 0; i < message.Length - substringLength + 1; i++)
            {
                if (message.Substring(i, substringLength) == findWhat)
                {
                    foundCount++;
                    i = i + substringLength;
                }
            }
            Console.WriteLine(foundCount);
        }

        public void verticalSentence(string sentence)
        {
            List<string> wordArray = new List<string>();
            string currentWord = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != (' '))
                {
                    currentWord += sentence[i];
                    if (i == sentence.Length - 1)
                    {
                        wordArray.Add(currentWord);
                    }
                }
                else if (sentence[i].Equals(' '))
                {
                    wordArray.Add(currentWord);
                    currentWord = "";
                }
            }
            wordArray.ForEach(Console.WriteLine);
        }

        public void reverseVert(string sentence)
        {
            List<string> wordArray = new List<string>();
            string currentWord = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != (' '))
                {
                    currentWord += sentence[i];
                    if (i == sentence.Length - 1)
                    {
                        wordArray.Add(currentWord);
                    }
                }
                else if (sentence[i].Equals(' '))
                {
                    wordArray.Add(currentWord);
                    currentWord = "";
                }
            }
            wordArray.Reverse();
            wordArray.ForEach(Console.WriteLine);
        }
    }
}
