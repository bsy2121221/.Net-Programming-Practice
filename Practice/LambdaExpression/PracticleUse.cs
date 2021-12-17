using System;
using System.Collections.Generic;

namespace LambdaExpression
{
    class PracticleUse
    {
        //With Anonymous Method
        static int GetNumber(List<int> numbersList)
        {
            return numbersList.Find(delegate(int n)
            {
                return n <10;
            });
        }

        public static void Call()
        {

            List<int> numbers = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                numbers.Add(i * 5);
            }

            int match = GetNumber(numbers);
            Console.WriteLine(match);

            //find the first number in the list that is below 10
            match = numbers.Find(n => n < 10);
            Console.WriteLine(match);
            Console.WriteLine("----------------------");

            var result = numbers.FindAll(n => n < 20);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            //print all the numbers in the list to the console
            numbers.ForEach(n => Console.WriteLine(n));
            Console.WriteLine("----------------------");

            //convert all the numbers in the list to floating-point values
            List<float> floatNumbers = numbers.ConvertAll<float>(n => (float)n);
            foreach (float f in floatNumbers)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("----------------------");

            numbers.Reverse();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------");

            //sort the numbers in reverse order
            numbers.Sort((x, y) => x.CompareTo(y));
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------");

            //filter out all odd numbers
            numbers.RemoveAll(n => n % 2 != 0);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------");

        }
    }
}
