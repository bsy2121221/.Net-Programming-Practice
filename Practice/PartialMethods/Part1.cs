using System;


namespace PartialMethods
{
    partial class MyPartialClass
    {
        partial void M();//The partial method must return void.
        static partial void N();//Partial methods are implicitly private
    }
}
