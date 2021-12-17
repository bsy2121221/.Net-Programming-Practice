using System;


namespace PartialMethods
{
    partial class MyPartialClass
    {
        partial void M()
        {
            Console.WriteLine("Partial Method M");
        }
        static partial void N()
        {
            Console.WriteLine("Static Partial Method Implemented");
        }

        public static void CallStaticMethod()
        {
            N();
        }
        public void CallNonStaticMethod()
        {
            this.M();
        }
    }
}
