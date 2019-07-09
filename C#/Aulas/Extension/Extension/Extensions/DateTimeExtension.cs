using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace System
{
    static class DateTimeExtension
    {
        public static string ElapsedTime(this DateTime dt)
        {
            
            TimeSpan Duration = DateTime.Now.Subtract(dt);
            if(Duration.TotalHours < 24.0)
            {
                return Duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
            }
            else
            {
                return Duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            }
        }
    }
}
