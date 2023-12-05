using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = new int[5];
            Console.WriteLine("Please enter 5 integer values of array's elements: ");
            for (int i = 0; i < myArray.Length; ++i)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum of all array's elements: {elementsSum(myArray)}");
            Console.WriteLine($"Average value of array's elements: {elementsAverage(myArray)}");
            Console.WriteLine($"The sum of the negative array's elements: {elementsNegativeSum(myArray)}");
            Console.WriteLine($"The sum of the positive array's elements: {elementsPositiveSum(myArray)}");
        }
        public static int elementsSum(int[] myArray)
        {
            int sum = 0;
            foreach (var item in myArray)
            {
                sum += item;
            }
            return sum;
        }
        public static double elementsAverage(int[] myArray)
        {
            return (double)elementsSum(myArray) / myArray.Length;
        }
        public static int elementsNegativeSum(int[] myArray)
        {
            int sumNegative = 0;
            foreach (int negEl in myArray)
            {
                if (negEl < 0)
                {
                    sumNegative += negEl;
                }
            }
            return sumNegative;
        }
        public static int elementsPositiveSum(int[] myArray)
        {
            int sumPositive = 0;
            foreach (int posEl in myArray)
            {
                if (posEl >= 0)
                {
                    sumPositive += posEl;
                }
            }
            return sumPositive;
        }
    }
}

