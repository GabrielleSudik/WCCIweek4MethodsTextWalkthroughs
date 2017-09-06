using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCCIweek4MethodsTextWalkthroughs
{
    class Program
    {
        //methods
        //variable number of arguments

            //see below for the method accepting an array

        static void Main(string[] args)
        {
            //to test the new method below
            //create an array
            //then pass the array to the method
            decimal[] booksTotalCost = { 25.99m, 13.00m, 56.24m }; //don't forget m for decimals

            PrintTotalAmountForBooks(booksTotalCost);

            //it worked!

            //now to do it with PARAMS
            //see second example below

            long sum1 = CalcSum(7, 9, 8);
            Console.WriteLine(sum1);

            long sum2 = CalcSum(10, 10, 10, 10);
            Console.WriteLine(sum2);

            long sum3 = CalcSum();
            Console.WriteLine(sum3);

            Console.WriteLine("\nHere's some random numbers, testing optional parameters.");
            Console.WriteLine("Default total of 4 numbers is 10.");

            FourNumbersAdded(); //10
            FourNumbersAdded(2, 3, 4, 5); //14
            FourNumbersAdded(y: 10); //17
            FourNumbersAdded(x: 10, y: 10); //25

            Console.ReadLine();
        }

        static void PrintTotalAmountForBooks (decimal[] prices) //this accepts an array of decimals
        {
            decimal totalAmount = 0;

            foreach (decimal singleBookPrice in prices) //plain old foreach loop
            {
                totalAmount += singleBookPrice;
            }

            Console.WriteLine($"The total amount for all books is ${totalAmount}.");
        }

        static long CalcSum(params int[] elements) //I guess this treats all the passed elements as an array
        {
            long sum = 0;

            foreach (int element in elements)
            {
                sum += element;
            }

            return sum;

            //note: parameter arrays must be the last item if it's a list of parameters
            //dunno if you can pass more than one array to a method. Don't think so.
        } 

        //the next one is testing optional default parameters
        //you're probably using the wrong words
        //but you seem to understand the concept

        public static void FourNumbersAdded (int w = 1, int x= 2, int y = 3, int z = 4)
        {
            int sumOfFour = w + x + y + z;
            Console.WriteLine(sumOfFour);
        }
    }
}
