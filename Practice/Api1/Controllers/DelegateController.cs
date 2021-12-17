using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DelegateController : ControllerBase
    {
        delegate double CalculateSimpleInterest(double p, double r, double t);
        CalculateSimpleInterest SI = SimpleInterest;
        public string Single()
        {
            //By help of invoke method
            double totalInterest1;
            totalInterest1 = SI.Invoke(1000, 10, 4);

            //By passing method
            CalculateSimpleInterest d = new CalculateSimpleInterest(SimpleInterest);
           double totalInterest2 = d(1200, 10, 4);

            return "invoke: "+totalInterest1+"\npassing method: "+totalInterest2;
        }
        public string MultiCast()
        {
            double totalInterest=SI.Invoke(1000, 10, 5);
            SI += new CalculateSimpleInterest(InterestRate);
            double Rate = SI.Invoke(totalInterest, 1000, 5);
            SI += InterestTime; //without constructor also you can bind with delegate
            double Time = SI(totalInterest, 1000, Rate);


            return "Interest: "+totalInterest+"\nRate: "+Rate+"\nTime: "+Time;
        }
       static double SimpleInterest(double p,double r, double t)
        {
            return (p * r * t) / 100;
        }
        static double InterestRate(double si,double p,double t)
        {
            return (si * 100) / (p * t);
        }
        static double InterestTime(double si, double p, double r)
        {
            return (si * 100) / (p * r);
        }

    }
    
}
