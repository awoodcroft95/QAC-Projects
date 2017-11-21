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
            peter.phy = 75;
            peter.che = 40;
            peter.mat = 90;

            smith.phy = 90;
            smith.che = 42;
            smith.mat = 100;

            peter.showResults();
            smith.showResults();
            Console.Read();
        }
    }

    class Results
    {
        public int phy, che, mat;

        public void showResults()
        {
            int total;
            float per;
            total = phy + che + mat;
            per = total * 100 / 450;

            Console.Write("Total marks: " + total + "\n");
            Console.Write("Percentage: " + per + "\n");
        }
    }
}
