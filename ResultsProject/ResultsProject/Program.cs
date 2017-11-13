using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Results peter, smith;
        peter = new Results();
        smith = new Results();
        peter.physics=20;
        peter.chemistry=50;
        peter.maths=150;

        smith.physics=91;
        smith.chemistry=91;
        smith.maths=91;

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
    private int maxMark = 150;
    private int minMark;
    private int passPercentage = 60;

    public int physics
    {
        set
        {
            if (value >= minMark && value <= maxMark)
            {
                phy = value;
            }
            else
            {
                Console.WriteLine("Invalid Physics Mark");
                phy = -1;
            }
        }

        get
        {
            return phy;
        }
    }

    public int chemistry
    {
        set
        {
            if (value >= minMark && value <= 150)
            {
                che = value;
            }
            else
            {
                Console.WriteLine("Invalid Mhemistry Mark");
                che = -1;
            }
        }
        get
        {
            return che;
        }
    }

    public int maths
    {
        set
        {
            if (value >= minMark && value <= 150)
            {
                mat = value;
            }
            else
            {
                Console.WriteLine("Invalid Maths Mark");
                mat = -1;
            }
        }
        get
        {
            return mat;
        }
    }

    public void showResults()
    {
        int total;
        float per;
        int numberOfPasses=0;
        if (phy > 0 && mat > 0 && che > 0)
        {
            if (((float)phy * 100 / maxMark) > passPercentage)
            {
                numberOfPasses++;
            }
            else
            {
                failedClasses.Add("Physics Failed");
            }

            if (((float)che * 100 / maxMark) > passPercentage)
            {
                numberOfPasses++;
            }

            else
            {
                failedClasses.Add("Chemistry Failed");
            }

            if (((float)mat * 100 / maxMark) > passPercentage)
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
                Console.Write("Percentage: " + per + "%\n");
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
            Console.WriteLine("No Results Available");
        }
    }
}