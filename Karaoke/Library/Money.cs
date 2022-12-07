using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Library
{
    public class Money
    {
        public static string format(double a)
        {
            return a.ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
        }
    }
}
