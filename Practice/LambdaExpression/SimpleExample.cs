using System;

namespace LambdaExpression
{
    delegate int del(int i);//Delegate Definition
    class SimpleExample
    {
        static int SQUARE(int n)
        {
            return n * n;
        }
        public static void Call()
        {
            del myDelegate = SQUARE;// Instantiating delegate and assigning named method
            int j = myDelegate(5);
            Console.WriteLine(j);

            del anotherDelegate = delegate(int n)//Anonymous Method
            {
                return n * n;
            };
            j = anotherDelegate(10);
            Console.WriteLine(j);

            del lambda = x => x * x;// Using Lambda Expression instead of delegate or anonymous method
            j = lambda(15);
            Console.WriteLine(j);

        }

    }
}
