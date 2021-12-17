using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    public static class StaticClass
    {
        public static double ToCelcious(double feren)
        {
            return (feren - 32) * 9 / 5;
        }
        public static double ToFerenhite(double celcious)
        {
            return celcious * 9 / 5 + 32;
        }
    }
}
