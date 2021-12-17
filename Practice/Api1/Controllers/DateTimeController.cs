using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1.Controllers
{
   
    [ApiController]
    public class DateTimeController : ControllerBase
    {
        [Route("Now")]

        public string Now()
        {
            DateTime dt = DateTime.Now;
            return dt.ToString();
        }

        [Route("Convert")]
        public string Convert()
        {
            DateTimeOffset offSet = DateTimeOffset.Parse(Now());
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTimeOffset psTime = TimeZoneInfo.ConvertTime(offSet, timeZoneInfo);
            foreach(var timeZoneInfo1 in TimeZoneInfo.GetSystemTimeZones())
            {
                DateTimeOffset psTime1 = TimeZoneInfo.ConvertTime(offSet, timeZoneInfo1);
                return psTime1.ToString();
            }
            return psTime.ToString();
        }
    }
}
