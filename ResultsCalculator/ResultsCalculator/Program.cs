using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Results peter, smith;
            peter = new Results();
            smith = new Results();
            peter.physics(20);
            peter.chemistry(50);
            peter.maths(150);

            smith.physics(91);
            smith.chemistry(91);
            smith.maths(91);

            Console.WriteLine("Peter's Results:");
            peter.showResults();
            Console.WriteLine("Smith's Results:");
            smith.showResults();
            Console.Read();


        }
    }

    class Results
    {
        private int phy, che, mat;
        private List<string> failedClasses = new List<string>();
        private Boolean validInput = true;

        public void physics(int a)
        {
            if (a >= 0 && a <= 150)
            {
                phy = a;
            }
            else
            {
                Console.WriteLine("Invalid Physics Mark");
                validInput = false;
            }
        }

        public void chemistry(int b)
        {
            if (b >= 0 && b <= 150)
            {
                che = b;
            }
            else
            {
                Console.WriteLine("Invalid Mhemistry Mark");
                validInput = false;
            }
        }

        public void maths(int c)
        {
            if (c >= 0 && c <= 150)
            {
                mat = c;
            }
            else
            {
                Console.WriteLine("Invalid Maths Mark");
                validInput = false;
            }
        }


        public void showResults()
        {
            int total;
            float per;
            int numberOfPasses = 0;
            if (phy > 0 && mat > 0 && che > 0 && validInput)
            {
                if (((float)phy * 100 / 150) > 60)
                {
                    numberOfPasses++;
                }
                else
                {
                    failedClasses.Add("Physics Failed");
                }
                if (((float)che * 100 / 150) > 60)
                {
                    numberOfPasses++;
                }
                else
                {
                    failedClasses.Add("Chemistry Failed");
                }
                if (((float)mat * 100 / 150) > 60)
                {
                    numberOfPasses++;
                }
                else
                {
                    failedClasses.Add("Maths Failed");
                }

                failedClasses.ForEach(Console.WriteLine);

                if (numberOfPasses == 3)
                {
                    total = phy + che + mat;
                    per = (float)total * 100 / 450;

                    Console.Write("Total marks: " + total + "\n");
                    Console.Write("Percentage: " + per + "\n");
                }
                else if (numberOfPasses == 2)
                {
                    Console.WriteLine("Retake exam");
                }
                else if (numberOfPasses == 1)
                {
                    Console.WriteLine("Repeat the course");
                }
                else
                {
                    Console.WriteLine("Go home");
                }
            }
            else
            {
                Console.Write("No Results Available");
            }
        }
    }
}
