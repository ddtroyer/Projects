using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Batting Average Calculator!" + Environment.NewLine);
            int validNumber;
            string answer = null;
            int validResult = 0;
            int[] AtBatResults = null;
            decimal sluggingAverage = 0.000m; ;
            decimal atBatAverage = 0.000m;
            decimal battingAverage = 0.000m;

            do
            {
                Console.Write("Enter number of times at bat: ");
                string strTimesAtBat = Console.ReadLine() + Environment.NewLine;

                while (!validTimesAtBat(strTimesAtBat, out validNumber))
                {
                    Console.WriteLine("Please try again: ");
                    strTimesAtBat = Console.ReadLine();
                }
                Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
                AtBatResults = new int[validNumber];
                for (int i = 0; i <= (validNumber - 1); i++)
                {
                    Console.Write("Result for at-bat " + (i + 1) + ": ");
                    string strResult = Console.ReadLine();

                    while (!validAtBat(strResult, out validResult))
                    {
                        Console.WriteLine("Please try again:");
                        strResult = Console.ReadLine();
                    }
                    AtBatResults[i] = validResult;
                }
                foreach (int item in AtBatResults)
                {
                    if (item > 0)
                    {
                        atBatAverage = (atBatAverage + 1);
                    }
                }
                battingAverage = (atBatAverage / validNumber);
                sluggingAverage = Convert.ToDecimal(AtBatResults.Average());
                var slugAverage = string.Format("{0:0.000}", sluggingAverage);

                Console.WriteLine("The batting average is: " + battingAverage);
                Console.WriteLine("The slugging average is: " + slugAverage);
                Console.WriteLine("Another batter? (y/n)");
                answer = Console.ReadLine();

                while (!yesOrNo(answer))
                {
                    Console.WriteLine("Please try again:");
                    answer = Console.ReadLine();
                }
            }
            while (answer == "y");
        }
        static bool validTimesAtBat(string strTimesAtBat, out int validNumber)//check for valid number times at bat
        {
            bool isValid = int.TryParse(strTimesAtBat, out validNumber);

            if (isValid && (validNumber >= 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool validAtBat(string result, out int validResult)//check for valid number for at bat
        {
            bool isValid = int.TryParse(result, out validResult);

            if (isValid && (validResult >= 0) && (validResult <= 4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool yesOrNo(string answer)
        {
            if (answer.ToLower() == "y" || answer.ToLower() == "n")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
