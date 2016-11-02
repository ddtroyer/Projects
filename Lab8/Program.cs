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
            Console.WriteLine("Welcome to Batting Average Calculator!");
            int validNumber;
            string answer;
            int validResult;
            int [] AtBatResults=null;
            double sluggingAverage;

            do
            {
                Console.WriteLine("Enter number of times at bat:");
                string strTimesAtBat = Console.ReadLine();

                while (!validTimesAtBat(strTimesAtBat, out validNumber))
                {
                    Console.WriteLine("Please try again:");
                    strTimesAtBat = Console.ReadLine();
                }
               
                Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");

                for (int i = 0; i <= (validNumber - 1); i++)
                {
                    Console.WriteLine("Result for at-bat " + (i + 1) + ":");
                    string strResult = Console.ReadLine();

                    while (!validAtBat(strResult, out validResult))
                    {
                        Console.WriteLine("Please try again:");
                        strResult = Console.ReadLine();
                    }

                    AtBatResults = new int [validNumber];
                    AtBatResults[i] = validResult;                  
                }

               sluggingAverage = (AtBatResults.Average());

                //foreach (int n = 0; n)
                //    {

                //}

                //battingAverage = (validResult!=0 / validNumber);
                //sluggingPercentage = (validResults+ / validNumber);
                //Console.WriteLine("Batting average: " + battingAverage));
                //calculate batting average & calculate slugging percentage)
                Console.WriteLine("The slugging average is: " + sluggingAverage);
                Console.WriteLine("The batting average is:");

                Console.WriteLine("Another batter? (y/n)");
                answer = Console.ReadLine();
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
    }
}
