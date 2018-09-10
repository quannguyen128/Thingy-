using System;

namespace CompoundingInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            double interestRate, annualCompound, years, prinInvest, total = 0.0;


            Console.Write("Enter Initital Investment (Press 0 to quit): \t");
            prinInvest = Convert.ToDouble(Console.ReadLine());

            while(prinInvest != 0)
            {

                
                Console.Write("Enter Interest Rate: \t");
                interestRate = Convert.ToDouble(Console.ReadLine()) / 100;

                Console.Write("How many years will the investment be? \t");
                years = Convert.ToDouble(Console.ReadLine());

                Console.Write("How many times a year would you like to compound? \t");
                annualCompound = Convert.ToDouble(Console.ReadLine());

                for (int t = 1; t < years + 1; t++)
                {
                    total = prinInvest * Math.Pow((1 + interestRate / annualCompound), (annualCompound * t));
                    Console.Write("Your Total for Year {0} " + "is {1}. \n", t, total);


                }
                Console.Write("Enter Initital Investment (Press 0 to quit): \t");
                prinInvest = Convert.ToDouble(Console.ReadLine());

            }
        }
    }
}
