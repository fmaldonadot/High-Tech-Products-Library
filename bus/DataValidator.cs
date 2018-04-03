using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace High_Tech_Products_Library.bus
{
    public static class DataValidator
    {
        public readonly static string patternDay = @"^([0-2][1-9]|[3][0-1])$";              // Day must be a value between 1 and 31
        public readonly static string patternMonth = @"^([0][1-9]|[1][0-2])$";              // Month must be a value between 1 and 12
        public readonly static string patternYear = @"^([1][9][0-9]{2}|[2][0][0-9]{2})$";   // Year must be a value between 1900 and 2099
        public readonly static string patternMoney = @"^[0-9]+[.]{0,1}[0-9]+$";             // Money must be a number 
        public readonly static string patternNumber = @"^[0-9]+$";                          // digits number
        
        public static bool verifyData(String str, Regex pattern)
        {
            return pattern.IsMatch(str);
        }

    }
}
