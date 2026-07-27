using Humanizer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UtilitiesClassLibrary
{
    public static class Tools
    {
        public static string GetHowManyTimeString(DateTime before, DateTime fater, string country)
        {
            string result = (fater - before).Humanize(culture: new CultureInfo(country));
            return result;
        }
    }
}
